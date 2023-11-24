using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_LibraryApplication.Office;

namespace WF_LibraryApplication.UIForms
{
    public partial class frmWordExamples : Form
    {
        String path = null;
        WordDocument wordDocument = null;

        public frmWordExamples()
        {
            InitializeComponent();
            path = tbFilePath.Text;
        }

        private string pathToTemplate
        {
            get
            {
                if (path == null)
                    return $@"{System.Windows.Forms.Application.StartupPath}\{tbFilePath.Text}";
                return path;
            }
        }

        private void btnOpenTemplateFile_Click(object sender, EventArgs e)
        {
            if(ofdWordTemplate.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = ofdWordTemplate.FileName;
                path = tbFilePath.Text;
            }
        }

        private void btnOpenEmptyDoc_Click(object sender, EventArgs e)
        {
            try
            {
                wordDocument = new WordDocument(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenTemplDoc_Click(object sender, EventArgs e)
        {
            try
            {
                wordDocument = new WordDocument(path);
                wordDocument.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!wordDocument.Closed)
            {
                try
                {
                    if (cbReplaceAll.Checked)
                        wordDocument.ReplaceAllStrings(tbTextToFind.Text, tbTextToReplace.Text);
                    else
                        wordDocument.ReplaceFirstString(tbTextToFind.Text, tbTextToReplace.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmWordExamples_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(wordDocument != null && !wordDocument.Closed)
                wordDocument.Close();
        }

        private void btnInsertText_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbInBookmark.Checked)
                {
                    wordDocument.SetSelectionToBookmark(tbBookmarkName.Text, asParagraph.Checked);
                    wordDocument.Selection.Text = tbInsertText.Text;
                }
                else if(rbInText.Checked)
                {
                    wordDocument.SetSelectionToBegin();
                    wordDocument.Selection.Text = tbInsertText.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            try
            {
                wordDocument.SetSelectionToBegin();
                wordDocument.InsertImage(tbImgPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeStyle_Click(object sender, EventArgs e)
        {
            try
            {
                string toFormatStr = tbTextToChangeStyle.Text;

                if (cbInRow.Checked)
                    wordDocument.SetSelectionToText(tbRowToFind.Text, toFormatStr);
                else
                    wordDocument.SetSelectionToText(toFormatStr);

                wordDocument.Selection.Bold = cbIsBold.Checked;
                if (cbByCenter.Checked)
                    wordDocument.Selection.Aligment = TextAligment.Center;

                wordDocument.Selection.FontSize = (int)nudFontSize.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertNewTable_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(tbFilePath.Text, insertTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertTable(WordDocument word)
        {
            word.SetSelectionToBookmark(tbBookmarkName.Text);
            if (!cbTableWithBorders.Checked)
                word.InsertTable(3, 3, BorderType.None);
            else word.InsertTable(3, 3);

            word.SetSelectionToCell(1, 1);
            word.Selection.Text = "First Table";

        }

        private void btnInsertRowsInTable_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(tbFilePath.Text, insertIntoTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertIntoTable(WordDocument word)
        {
            int n = (int)nudTableN.Value;

            word.SelectTable(n);

            word.SetSelectionToCell(1, 1);
            word.Selection.Text = "First Value";

            int addRows = (int)nudRowsCount.Value;

            for(int i = 1; i <= addRows; i++)
            {
                word.AddRowToTable();
                word.SetSelectionToCell(word.RowCount(), 1);
                word.Selection.Text = $"{word.RowCount()} row";
            }

        }

        private void btnInsertSheets_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument wTemplate = null;



                for (int i = 0; i < nudSheeetsCount.Value; i++)
                {
                    wTemplate = new WordDocument(path);
                    WordDocument.FillShowTemplate(wTemplate, insertDataInDocument);
                    String newPath = path.Replace(".dot", $"{i}");
                    wTemplate.Save(newPath);
                    wTemplate.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertDataInDocument(WordDocument word)
        {
            try
            {

                
                   // wTemplate.Visible = true;
                    complexTextInsert(word);
                word.InsertParagraphAfter();
                    
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void complexTextInsert(WordDocument word)
        {
            word.InsertParagraphAfter(tbInsertText.Text);
            word.InsertParagraphAfter();
            word.InsertParagraphAfter(tbRowToFind.Text);
            word.Selection.Bold = true;
            word.Selection.Italic = true;
            word.Selection.FontSize = 20;
            word.Selection.Border = BorderType.Double;
        }

    }
}

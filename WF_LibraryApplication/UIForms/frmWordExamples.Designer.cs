namespace WF_LibraryApplication.UIForms
{
    partial class frmWordExamples
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenTemplateFile = new System.Windows.Forms.Button();
            this.btnOpenEmptyDoc = new System.Windows.Forms.Button();
            this.btnOpenTemplDoc = new System.Windows.Forms.Button();
            this.tbTextToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTextToReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBookmarkName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInsertText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnInsertText = new System.Windows.Forms.Button();
            this.cbReplaceAll = new System.Windows.Forms.CheckBox();
            this.asParagraph = new System.Windows.Forms.CheckBox();
            this.rbInBookmark = new System.Windows.Forms.RadioButton();
            this.rbInText = new System.Windows.Forms.RadioButton();
            this.btnInsertImg = new System.Windows.Forms.Button();
            this.tbImgPath = new System.Windows.Forms.TextBox();
            this.cbInRow = new System.Windows.Forms.CheckBox();
            this.tbRowToFind = new System.Windows.Forms.TextBox();
            this.tbTextToChangeStyle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChangeStyle = new System.Windows.Forms.Button();
            this.cbIsBold = new System.Windows.Forms.CheckBox();
            this.cbIsItalic = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.cbByCenter = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTableWithBorders = new System.Windows.Forms.CheckBox();
            this.btnInsertNewTable = new System.Windows.Forms.Button();
            this.nudTableN = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudRowsCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsertRowsInTable = new System.Windows.Forms.Button();
            this.nudSheeetsCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInsertSheets = new System.Windows.Forms.Button();
            this.ofdWordTemplate = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheeetsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Template file path";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(12, 27);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(529, 20);
            this.tbFilePath.TabIndex = 1;
            this.tbFilePath.Text = "C:\\Users\\Krystsina\\source\\repos\\Pv1_22PO\\WF_LibraryApplication\\bin\\Debug\\testWord" +
    "Template.dot";
            this.tbFilePath.TextChanged += new System.EventHandler(this.tbFilePath_TextChanged);
            // 
            // btnOpenTemplateFile
            // 
            this.btnOpenTemplateFile.Location = new System.Drawing.Point(553, 24);
            this.btnOpenTemplateFile.Name = "btnOpenTemplateFile";
            this.btnOpenTemplateFile.Size = new System.Drawing.Size(150, 23);
            this.btnOpenTemplateFile.TabIndex = 2;
            this.btnOpenTemplateFile.Text = "OpenTemplate";
            this.btnOpenTemplateFile.UseVisualStyleBackColor = true;
            this.btnOpenTemplateFile.Click += new System.EventHandler(this.btnOpenTemplateFile_Click);
            // 
            // btnOpenEmptyDoc
            // 
            this.btnOpenEmptyDoc.Location = new System.Drawing.Point(391, 53);
            this.btnOpenEmptyDoc.Name = "btnOpenEmptyDoc";
            this.btnOpenEmptyDoc.Size = new System.Drawing.Size(150, 23);
            this.btnOpenEmptyDoc.TabIndex = 3;
            this.btnOpenEmptyDoc.Text = "Open Empty Document";
            this.btnOpenEmptyDoc.UseVisualStyleBackColor = true;
            this.btnOpenEmptyDoc.Click += new System.EventHandler(this.btnOpenEmptyDoc_Click);
            // 
            // btnOpenTemplDoc
            // 
            this.btnOpenTemplDoc.Location = new System.Drawing.Point(553, 53);
            this.btnOpenTemplDoc.Name = "btnOpenTemplDoc";
            this.btnOpenTemplDoc.Size = new System.Drawing.Size(150, 23);
            this.btnOpenTemplDoc.TabIndex = 4;
            this.btnOpenTemplDoc.Text = "Open Templated Document";
            this.btnOpenTemplDoc.UseVisualStyleBackColor = true;
            this.btnOpenTemplDoc.Click += new System.EventHandler(this.btnOpenTemplDoc_Click);
            // 
            // tbTextToFind
            // 
            this.tbTextToFind.Location = new System.Drawing.Point(15, 103);
            this.tbTextToFind.Name = "tbTextToFind";
            this.tbTextToFind.Size = new System.Drawing.Size(166, 20);
            this.tbTextToFind.TabIndex = 6;
            this.tbTextToFind.Text = "@@testReplace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text to find:";
            // 
            // tbTextToReplace
            // 
            this.tbTextToReplace.Location = new System.Drawing.Point(187, 103);
            this.tbTextToReplace.Name = "tbTextToReplace";
            this.tbTextToReplace.Size = new System.Drawing.Size(198, 20);
            this.tbTextToReplace.TabIndex = 8;
            this.tbTextToReplace.Text = "!!!New Text!!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Replace to:";
            // 
            // tbBookmarkName
            // 
            this.tbBookmarkName.Location = new System.Drawing.Point(15, 149);
            this.tbBookmarkName.Name = "tbBookmarkName";
            this.tbBookmarkName.Size = new System.Drawing.Size(166, 20);
            this.tbBookmarkName.TabIndex = 10;
            this.tbBookmarkName.Text = "testBookmark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bookmark name:";
            // 
            // tbInsertText
            // 
            this.tbInsertText.Location = new System.Drawing.Point(187, 149);
            this.tbInsertText.Name = "tbInsertText";
            this.tbInsertText.Size = new System.Drawing.Size(198, 20);
            this.tbInsertText.TabIndex = 12;
            this.tbInsertText.Text = "!!!New Bookmark Text!!!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insert Text:";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(391, 100);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(150, 23);
            this.btnReplace.TabIndex = 13;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnInsertText
            // 
            this.btnInsertText.Location = new System.Drawing.Point(391, 146);
            this.btnInsertText.Name = "btnInsertText";
            this.btnInsertText.Size = new System.Drawing.Size(150, 23);
            this.btnInsertText.TabIndex = 14;
            this.btnInsertText.Text = "Insert Text";
            this.btnInsertText.UseVisualStyleBackColor = true;
            this.btnInsertText.Click += new System.EventHandler(this.btnInsertText_Click);
            // 
            // cbReplaceAll
            // 
            this.cbReplaceAll.AutoSize = true;
            this.cbReplaceAll.Location = new System.Drawing.Point(547, 100);
            this.cbReplaceAll.Name = "cbReplaceAll";
            this.cbReplaceAll.Size = new System.Drawing.Size(36, 17);
            this.cbReplaceAll.TabIndex = 15;
            this.cbReplaceAll.Text = "all";
            this.cbReplaceAll.UseVisualStyleBackColor = true;
            // 
            // asParagraph
            // 
            this.asParagraph.AutoSize = true;
            this.asParagraph.Location = new System.Drawing.Point(547, 146);
            this.asParagraph.Name = "asParagraph";
            this.asParagraph.Size = new System.Drawing.Size(88, 17);
            this.asParagraph.TabIndex = 16;
            this.asParagraph.Text = "as paragraph";
            this.asParagraph.UseVisualStyleBackColor = true;
            // 
            // rbInBookmark
            // 
            this.rbInBookmark.AutoSize = true;
            this.rbInBookmark.Checked = true;
            this.rbInBookmark.Location = new System.Drawing.Point(187, 175);
            this.rbInBookmark.Name = "rbInBookmark";
            this.rbInBookmark.Size = new System.Drawing.Size(86, 17);
            this.rbInBookmark.TabIndex = 17;
            this.rbInBookmark.TabStop = true;
            this.rbInBookmark.Text = "by bookmark";
            this.rbInBookmark.UseVisualStyleBackColor = true;
            // 
            // rbInText
            // 
            this.rbInText.AutoSize = true;
            this.rbInText.Location = new System.Drawing.Point(278, 175);
            this.rbInText.Name = "rbInText";
            this.rbInText.Size = new System.Drawing.Size(75, 17);
            this.rbInText.TabIndex = 18;
            this.rbInText.Text = "before text";
            this.rbInText.UseVisualStyleBackColor = true;
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.Location = new System.Drawing.Point(391, 195);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(150, 23);
            this.btnInsertImg.TabIndex = 20;
            this.btnInsertImg.Text = "Insert Img";
            this.btnInsertImg.UseVisualStyleBackColor = true;
            this.btnInsertImg.Click += new System.EventHandler(this.btnInsertImg_Click);
            // 
            // tbImgPath
            // 
            this.tbImgPath.Location = new System.Drawing.Point(187, 198);
            this.tbImgPath.Name = "tbImgPath";
            this.tbImgPath.Size = new System.Drawing.Size(198, 20);
            this.tbImgPath.TabIndex = 19;
            this.tbImgPath.Text = "C:\\Users\\Krystsina\\Pictures\\Money\\1f.jpg";
            // 
            // cbInRow
            // 
            this.cbInRow.AutoSize = true;
            this.cbInRow.Location = new System.Drawing.Point(18, 231);
            this.cbInRow.Name = "cbInRow";
            this.cbInRow.Size = new System.Drawing.Size(74, 17);
            this.cbInRow.TabIndex = 21;
            this.cbInRow.Text = "find in row";
            this.cbInRow.UseVisualStyleBackColor = true;
            // 
            // tbRowToFind
            // 
            this.tbRowToFind.Location = new System.Drawing.Point(15, 254);
            this.tbRowToFind.Name = "tbRowToFind";
            this.tbRowToFind.Size = new System.Drawing.Size(370, 20);
            this.tbRowToFind.TabIndex = 22;
            this.tbRowToFind.Text = "Этот объект представляет текущий экземпляр Word. Объект Application содержит объе" +
    "кты Document, Selection, Bookmark и Range";
            // 
            // tbTextToChangeStyle
            // 
            this.tbTextToChangeStyle.Location = new System.Drawing.Point(15, 302);
            this.tbTextToChangeStyle.Name = "tbTextToChangeStyle";
            this.tbTextToChangeStyle.Size = new System.Drawing.Size(370, 20);
            this.tbTextToChangeStyle.TabIndex = 24;
            this.tbTextToChangeStyle.Text = "Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Text to find and change format:";
            // 
            // btnChangeStyle
            // 
            this.btnChangeStyle.Location = new System.Drawing.Point(391, 299);
            this.btnChangeStyle.Name = "btnChangeStyle";
            this.btnChangeStyle.Size = new System.Drawing.Size(150, 23);
            this.btnChangeStyle.TabIndex = 25;
            this.btnChangeStyle.Text = "Change Style";
            this.btnChangeStyle.UseVisualStyleBackColor = true;
            this.btnChangeStyle.Click += new System.EventHandler(this.btnChangeStyle_Click);
            // 
            // cbIsBold
            // 
            this.cbIsBold.AutoSize = true;
            this.cbIsBold.Location = new System.Drawing.Point(12, 328);
            this.cbIsBold.Name = "cbIsBold";
            this.cbIsBold.Size = new System.Drawing.Size(46, 17);
            this.cbIsBold.TabIndex = 26;
            this.cbIsBold.Text = "bold";
            this.cbIsBold.UseVisualStyleBackColor = true;
            // 
            // cbIsItalic
            // 
            this.cbIsItalic.AutoSize = true;
            this.cbIsItalic.Location = new System.Drawing.Point(98, 328);
            this.cbIsItalic.Name = "cbIsItalic";
            this.cbIsItalic.Size = new System.Drawing.Size(47, 17);
            this.cbIsItalic.TabIndex = 27;
            this.cbIsItalic.Text = "italic";
            this.cbIsItalic.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Font Size:";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(239, 325);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(120, 20);
            this.nudFontSize.TabIndex = 29;
            this.nudFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbByCenter
            // 
            this.cbByCenter.AutoSize = true;
            this.cbByCenter.Location = new System.Drawing.Point(392, 330);
            this.cbByCenter.Name = "cbByCenter";
            this.cbByCenter.Size = new System.Drawing.Size(70, 17);
            this.cbByCenter.TabIndex = 30;
            this.cbByCenter.Text = "by center";
            this.cbByCenter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertSheets);
            this.groupBox1.Controls.Add(this.nudSheeetsCount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnInsertRowsInTable);
            this.groupBox1.Controls.Add(this.nudRowsCount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nudTableN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnInsertNewTable);
            this.groupBox1.Controls.Add(this.cbTableWithBorders);
            this.groupBox1.Location = new System.Drawing.Point(12, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 139);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table";
            // 
            // cbTableWithBorders
            // 
            this.cbTableWithBorders.AutoSize = true;
            this.cbTableWithBorders.Location = new System.Drawing.Point(6, 19);
            this.cbTableWithBorders.Name = "cbTableWithBorders";
            this.cbTableWithBorders.Size = new System.Drawing.Size(98, 17);
            this.cbTableWithBorders.TabIndex = 32;
            this.cbTableWithBorders.Text = "without borders";
            this.cbTableWithBorders.UseVisualStyleBackColor = true;
            // 
            // btnInsertNewTable
            // 
            this.btnInsertNewTable.Location = new System.Drawing.Point(110, 13);
            this.btnInsertNewTable.Name = "btnInsertNewTable";
            this.btnInsertNewTable.Size = new System.Drawing.Size(150, 23);
            this.btnInsertNewTable.TabIndex = 32;
            this.btnInsertNewTable.Text = "Insert New table";
            this.btnInsertNewTable.UseVisualStyleBackColor = true;
            this.btnInsertNewTable.Click += new System.EventHandler(this.btnInsertNewTable_Click);
            // 
            // nudTableN
            // 
            this.nudTableN.Location = new System.Drawing.Point(57, 52);
            this.nudTableN.Name = "nudTableN";
            this.nudTableN.Size = new System.Drawing.Size(56, 20);
            this.nudTableN.TabIndex = 33;
            this.nudTableN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Table N:";
            // 
            // nudRowsCount
            // 
            this.nudRowsCount.Location = new System.Drawing.Point(231, 52);
            this.nudRowsCount.Name = "nudRowsCount";
            this.nudRowsCount.Size = new System.Drawing.Size(120, 20);
            this.nudRowsCount.TabIndex = 35;
            this.nudRowsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "number of rows";
            // 
            // btnInsertRowsInTable
            // 
            this.btnInsertRowsInTable.Location = new System.Drawing.Point(366, 52);
            this.btnInsertRowsInTable.Name = "btnInsertRowsInTable";
            this.btnInsertRowsInTable.Size = new System.Drawing.Size(150, 23);
            this.btnInsertRowsInTable.TabIndex = 32;
            this.btnInsertRowsInTable.Text = "Insert Into Table";
            this.btnInsertRowsInTable.UseVisualStyleBackColor = true;
            this.btnInsertRowsInTable.Click += new System.EventHandler(this.btnInsertRowsInTable_Click);
            // 
            // nudSheeetsCount
            // 
            this.nudSheeetsCount.Location = new System.Drawing.Point(125, 80);
            this.nudSheeetsCount.Name = "nudSheeetsCount";
            this.nudSheeetsCount.Size = new System.Drawing.Size(67, 20);
            this.nudSheeetsCount.TabIndex = 37;
            this.nudSheeetsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "number of new sheets:";
            // 
            // btnInsertSheets
            // 
            this.btnInsertSheets.Location = new System.Drawing.Point(193, 77);
            this.btnInsertSheets.Name = "btnInsertSheets";
            this.btnInsertSheets.Size = new System.Drawing.Size(150, 23);
            this.btnInsertSheets.TabIndex = 38;
            this.btnInsertSheets.Text = "Insert Template";
            this.btnInsertSheets.UseVisualStyleBackColor = true;
            this.btnInsertSheets.Click += new System.EventHandler(this.btnInsertSheets_Click);
            // 
            // ofdWordTemplate
            // 
            this.ofdWordTemplate.FileName = "testWordTemplate";
            this.ofdWordTemplate.Filter = "Template|*.dot|All Files|*.*";
            this.ofdWordTemplate.InitialDirectory = "C:\\Users\\Krystsina\\source\\repos\\Pv1_22PO\\WF_LibraryApplication\\bin\\Debug";
            // 
            // frmWordExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbByCenter);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbIsItalic);
            this.Controls.Add(this.cbIsBold);
            this.Controls.Add(this.btnChangeStyle);
            this.Controls.Add(this.tbTextToChangeStyle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbRowToFind);
            this.Controls.Add(this.cbInRow);
            this.Controls.Add(this.btnInsertImg);
            this.Controls.Add(this.tbImgPath);
            this.Controls.Add(this.rbInText);
            this.Controls.Add(this.rbInBookmark);
            this.Controls.Add(this.asParagraph);
            this.Controls.Add(this.cbReplaceAll);
            this.Controls.Add(this.btnInsertText);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbInsertText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBookmarkName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTextToReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTextToFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenTemplDoc);
            this.Controls.Add(this.btnOpenEmptyDoc);
            this.Controls.Add(this.btnOpenTemplateFile);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label1);
            this.Name = "frmWordExamples";
            this.Text = "frmWordExamples";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWordExamples_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheeetsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnOpenTemplateFile;
        private System.Windows.Forms.Button btnOpenEmptyDoc;
        private System.Windows.Forms.Button btnOpenTemplDoc;
        private System.Windows.Forms.TextBox tbTextToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTextToReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBookmarkName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInsertText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnInsertText;
        private System.Windows.Forms.CheckBox cbReplaceAll;
        private System.Windows.Forms.CheckBox asParagraph;
        private System.Windows.Forms.RadioButton rbInBookmark;
        private System.Windows.Forms.RadioButton rbInText;
        private System.Windows.Forms.Button btnInsertImg;
        private System.Windows.Forms.TextBox tbImgPath;
        private System.Windows.Forms.CheckBox cbInRow;
        private System.Windows.Forms.TextBox tbRowToFind;
        private System.Windows.Forms.TextBox tbTextToChangeStyle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChangeStyle;
        private System.Windows.Forms.CheckBox cbIsBold;
        private System.Windows.Forms.CheckBox cbIsItalic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.CheckBox cbByCenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertSheets;
        private System.Windows.Forms.NumericUpDown nudSheeetsCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInsertRowsInTable;
        private System.Windows.Forms.NumericUpDown nudRowsCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudTableN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsertNewTable;
        private System.Windows.Forms.CheckBox cbTableWithBorders;
        private System.Windows.Forms.OpenFileDialog ofdWordTemplate;
    }
}
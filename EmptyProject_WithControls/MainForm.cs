using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EmptyProject_WithControls
{
    internal class MainForm : Form
    {
        const int MARGIN = 10;
        int left = 0, top = 0;
        int hForm = 400, wForm = 300;
        int size = 45;

        GroupBox gbSimleButtons;
        GroupBox gbExtendedButton;
        Panel panel;
        TextBox textBox;
        Button btn;
        ExtendedButton btnExtended;

        public MainForm()
        {
            #region From Properties
            this.Text = "Main Form";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(wForm, hForm);
            this.MinimumSize = new Size(wForm, hForm);

            this.AutoScaleDimensions = new SizeF(90, 90);
            this.AutoScaleMode = AutoScaleMode.Dpi;


            #endregion

            #region Simple Buttons
            gbSimleButtons = new GroupBox();
            gbSimleButtons.Text = "Simple Buttons with One Action";
            gbSimleButtons.Location = new Point(MARGIN, MARGIN);
            gbSimleButtons.Size = new Size(this.ClientSize.Width - MARGIN * 2,
                size + MARGIN * 2);
            gbSimleButtons.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            
            //this.Controls.Add(gbSimleButtons);
            gbSimleButtons.Parent = this;

            

            btn = new Button();
            btn.Text = "Simple Button 1";
            btn.AutoSize = true;
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            left = (gbSimleButtons.Size.Width / 2 - 2 * MARGIN - btn.Width);
            top = MARGIN * 2;
            btn.Location = new Point(left, top);
            btn.Anchor = AnchorStyles.Top;
            btn.Click += btnOnClick;

            btn.Parent = gbSimleButtons;

            btn = new Button()
            {
                Text = "Simple Button 2",
                AutoSize = true,
                Anchor = AnchorStyles.Top,
                Enabled = false,
                Location = new Point(gbSimleButtons.Size.Width / 2 + MARGIN, top),
                Parent = gbSimleButtons
            };

            btn.Click += btnOnClick;



            btn = null;


            #endregion

            #region Extended Button with Text Box Dependency
            gbExtendedButton = new GroupBox()
            {
                Text = "Extended Button with Properties",
                Width = gbSimleButtons.Width,
                Height = size * 2,
                Anchor = gbSimleButtons.Anchor,
                Location = new Point(MARGIN, gbSimleButtons.Top + gbSimleButtons.Height + MARGIN),
                Parent = this
            };

            textBox = new TextBox()
            {
                CharacterCasing = CharacterCasing.Upper,
                //Text = "Button",
                Width = size * 4,
                Top = MARGIN * 2,
                Anchor = AnchorStyles.Top,
                Parent = gbExtendedButton
            };
            textBox.Left = (gbExtendedButton.ClientSize.Width - textBox.Width) / 2;
            textBox.Focus();
            textBox.TextChanged += textBoxTextChanged;

            btnExtended = new ExtendedButton()
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoSize = true,
                Top = textBox.Top + textBox.Height + MARGIN,
                Anchor = AnchorStyles.Top,
                Parent = gbExtendedButton
            };

            //btnExtended.StrTextBox = textBox.Text;

            textBox.Text = "Button";
            btnExtended.Click += extButtonOnClick;

            panel = new Panel()
            {
                Width = gbExtendedButton.Width,
                Height = this.ClientSize.Height
                    - gbSimleButtons.Height
                    - gbExtendedButton.Height
                    - MARGIN * 4,
                Left = MARGIN,
                Top = gbExtendedButton.Top + gbExtendedButton.Height + MARGIN,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                    | AnchorStyles.Bottom,
                Parent = this
            };



            #endregion


        }

        void btnOnClick(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                btn = sender as Button; //(Button)sender
                MessageBox.Show($"{btn.Text} Clicked", "Simple Button Message");
                foreach(Control control in gbSimleButtons.Controls)
                    control.Enabled = !control.Enabled;
            }
        }

        void textBoxTextChanged(object sender, EventArgs e)
        {
            btnExtended.StrTextBox = textBox.Text;
        }

        void extButtonOnClick(object sender, EventArgs e)
        {
            ModalDialogBox dialogBox = new ModalDialogBox();
            if(dialogBox.ShowDialog() == DialogResult.OK)
            {
                Random rnd = new Random();
                int iShade = rnd.Next(255);
                if (dialogBox.GrayShades)
                    panel.BackColor = Color.FromArgb(iShade, iShade, iShade);
                else
                    panel.BackColor= Color.FromArgb(iShade, rnd.Next(255), rnd.Next(255));
            }
        }
    }
}

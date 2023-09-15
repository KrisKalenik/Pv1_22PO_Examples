using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EmptyProject_WithControls
{
    internal class ModalDialogBox : Form
    {
        CheckBox cbGrayShades;
        Size btnSize = new Size(48, 14);
        int left = 16, top = 8;

        public ModalDialogBox()
        {
            this.Text = "Panel BackColor";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;

            this.ClientSize = new Size(left * 9, top * 7);
            this.Location = ActiveForm.Location
                + SystemInformation.CaptionButtonSize
                + SystemInformation.FrameBorderSize;

            

            cbGrayShades = new CheckBox()
            {
                Text = "Only Gray Colors",
                Location = new Point(left, top),
                Size = new Size(this.ClientSize.Width - left - top / 2,
                left - top / 2),
                Parent = this
            };

            Button btnOK = new Button()
            {
                Text = "OK",
                Location = new Point(top * 2, left * 2),
                Size = btnSize,
                DialogResult = DialogResult.OK,
                Parent = this
            };

            Button btnCancel = new Button()
            {
                Text = "Cancel",
                Location = new Point(top * 10, left * 2),
                Size = btnSize,
                DialogResult = DialogResult.Cancel,
                Parent = this
            };

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;

            this.AutoScaleDimensions = new Size(4, 8);
            this.AutoScaleMode = AutoScaleMode.Font;


        }

        public bool GrayShades
        {
            private set { cbGrayShades.Checked = value; }
            get { return cbGrayShades.Checked; }
        }


    }
}

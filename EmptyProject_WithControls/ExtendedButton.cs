using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EmptyProject_WithControls
{
    internal class ExtendedButton : Button
    {
        const int MIN_DISABLED = 5;

        public string StrTextBox
        {
            set
            {
                //objectName.StrTextBox = "some value";
                this.Text = value;
                bool enabled = value != null && value.Length > MIN_DISABLED;
                this.Enabled = enabled;
                if(this.Parent != null)
                {
                    this.Left = (this.Parent.ClientSize.Width - this.Width) / 2;
                }

            }

            private get
            {
                return "def";
            }
        }

        public string someProperty { get; private set; }
    }
}

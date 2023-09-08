using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EmptyProject
{
    internal class MyNewForm : MyMainForm
    {
        public MyNewForm()
        {
            this.Paint += MyNewPaint;
            this.Paint += MyNewPaint;

        }

        public override void MyClick(object sender, EventArgs e)
        {
            //base.MyClick(sender, e);

            this.Height = this.Width * 2;
        }

        public void MyNewPaint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("New Pain");
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            //base.OnMouseEnter(e);
            MessageBox.Show("Mouse Enter");
        }
    }
}

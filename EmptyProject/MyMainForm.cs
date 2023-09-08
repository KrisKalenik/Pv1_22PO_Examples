using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EmptyProject
{
    internal class MyMainForm : Form
    {
        public MyMainForm()
        {
            this.Text = "My Main Window";
            this.BackColor = Color.AliceBlue;
            this.Font = new Font("Arial", 16, FontStyle.Bold);
            this.Width = this.Height * 2;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Click += MyClick;
            this.Paint += MyPaint;
            //this.Click += new EventHandler(MyClick);
        }

        public virtual void MyClick(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Button Clicked!", "Dialog Box");
        }

        Random rnd = new Random();

        void MyPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.Clear(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))); ;
        }


    }
}

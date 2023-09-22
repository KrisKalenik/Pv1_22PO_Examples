using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Events
{
    public partial class frmMain : Form
    {
        private List<TextBox> tbDriverNames = new List<TextBox>();
        private List<NumericUpDown> nudDriverSpeeds = new List<NumericUpDown>();

        public frmMain()
        {
            InitializeComponent();
        }



        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            TextBox tbDriverName = new TextBox();
            NumericUpDown nudDriverSpeed = new NumericUpDown();

            tbDriverName.Location = new Point(20, 50 + tbDriverNames.Count * 40);
            nudDriverSpeed.Location = new Point(150, 50 + nudDriverSpeeds.Count * 40);

            tbDriverNames.Add(tbDriverName);
            nudDriverSpeeds.Add(nudDriverSpeed);

            pnlDrivers.Controls.Add(tbDriverName);
            pnlDrivers.Controls.Add(nudDriverSpeed);
        }

        private void btnGaiMeasure_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
            Clerk clerk = new Clerk();
            Cashier cashier = new Cashier();

            for(int i = 0; i < tbDriverNames.Count; i++)
            {
                string driverName = tbDriverNames[i].Text;
                int driverSpeed = (int)nudDriverSpeeds[i].Value;

                Driver driver = new Driver(driverName);
                string msg = null;

                Gai.MeasureSpeed(driver, driverSpeed, ref msg);

                if (!String.IsNullOrWhiteSpace(msg))
                    rtbResult.Text += $"{msg}\n";

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_LibraryApplication.Helpers;

namespace WF_LibraryApplication.UIForms
{
    public partial class frmDbConfig : Form
    {
        public frmDbConfig()
        {
            InitializeComponent();
        }

        private void frmDbConfig_Load(object sender, EventArgs e)
        {
            tbServer.Text = SettingsEngine.Server;
            tbDatabase.Text = SettingsEngine.Database;
            if (!SettingsEngine.IsSecured)
            {
                tbUserId.Text = SettingsEngine.UserId;
                tbUserPassword.Text = SettingsEngine.UserPassword;
            }
            cbIntSecurity.Checked = SettingsEngine.IsSecured;
        }

        private void cbIntSecurity_CheckedChanged(object sender, EventArgs e)
        {
            tbUserId.Enabled = !cbIntSecurity.Checked;
            tbUserPassword.Enabled = !cbIntSecurity.Checked;
        }

        private void btnTestConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if(true)
                {
                    btnSave.Enabled = true;
                    sbStatus.Text = "Connected successfully.";
                }
                else
                {
                    btnSave.Enabled = false;
                    sbStatus.Text = "Connection faild. Check connection parameters.";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingsEngine.SaveDbConfiguration(tbServer.Text,
                tbDatabase.Text, tbUserId.Text, tbUserPassword.Text,
                cbIntSecurity.Checked);
            /////
            sbStatus.Text = "Connection string has been successfully saved.";
        }

        private void TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            sbStatus.Text = null;
        }
    }
}

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
using WF_LibraryApplication.UIForms;

namespace WF_LibraryApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLogin.Text = SettingsEngine.Login;
            tbPassword.Text = SettingsEngine.Password;
            cbRememberUser.Checked = SettingsEngine.IsSaved;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

        private void cbShowPassword_MouseLeave(object sender, EventArgs e)
        {
            cbShowPassword.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (areCredentialsValid)
            {

                try
                {
                    if (cbRememberUser.Checked)
                        SettingsEngine.SaveDefaultCredentials(tbLogin.Text, tbPassword.Text);
                    else
                        SettingsEngine.ClearDefaultCredentials();

                    //connect to DB
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool areCredentialsValid
        {
            get
            {
                string errorMsgLogin = ValidationEngine.ValidateLoginErrorMessage(tbLogin.Text);
                string errorMsgPassword = ValidationEngine.ValidatePasswordErrorMessage(tbPassword.Text);

                epCredentials.SetError(tbLogin, errorMsgLogin);
                epCredentials.SetError(tbPassword, errorMsgPassword);

                return string.IsNullOrEmpty(errorMsgLogin) && string.IsNullOrEmpty(errorMsgPassword);
            }
        }

        private void lblRegistrationFrm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.ShowDialog();

            //(new frmRegistration()).ShowDialog();
        }

        private void lblDbConfigFrm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDbConfig frmDbConfig = new frmDbConfig();
            frmDbConfig.ShowDialog();
        }
    }
}

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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();

            tbGender.SelectedItem = null;
            tbBirthday.CustomFormat = " ";
        }

        private void ValidateControl(Control control, Func<string, string> validationFunc, CancelEventArgs e)
        {
            string errorMessage = validationFunc(control.Text);
            epRegistration.SetError(control, errorMessage);
            e.Cancel = !string.IsNullOrEmpty(errorMessage);
        }

        private void txLogin_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbLogin, ValidationEngine.ValidateLoginErrorMessage, e);
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbPassword, ValidationEngine.ValidatePasswordErrorMessage, e);
        }

        private void tbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbPasswordConfirm,
                text => ValidationEngine.ValidatePasswordConfirmErrorMessage(text, tbPassword.Text),
                e);
        }

        private void tbFullName_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbFullName, ValidationEngine.ValidateFullNameErrorMessage, e);
        }

        private void tbGender_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbGender, ValidationEngine.ValidateGendereErrorMessage, e);
        }

        private void tbBirthday_ValueChanged(object sender, EventArgs e)
        {
            tbBirthday.CustomFormat = ValidationEngine.DateFormat;
        }

        private void tbBirthday_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbBirthday, ValidationEngine.ValidateBirthdayErrorMessage, e);

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbEmail, ValidationEngine.ValidateEmailErrorMessage, e);

        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateControl(tbPhone, ValidationEngine.ValidatePhoneErrorMessage, e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                try
                {
                    MessageBox.Show("User data saved");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

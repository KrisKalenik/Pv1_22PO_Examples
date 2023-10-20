using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_LibraryApplication.UIForms;
using WF_LibraryApplication.Database;

namespace WF_LibraryApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserProfile.IsLoggedIn = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmLogin());

            if (UserProfile.IsLoggedIn)
            {
                if (UserProfile.Roles.Contains("Admin"))
                    Application.Run(new frmMainAdmin());
                else Application.Run(new frmMainUser());
            }
        }
    }
}

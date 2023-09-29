using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_LibraryApplication.Helpers
{
    internal class SettingsEngine
    {
        public static string Login
        {
            get => Properties.Settings.Default.usrLogin;
            private set
            {
                Properties.Settings.Default.usrLogin = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string Password
        {
            get => String.IsNullOrEmpty(Properties.Settings.Default.usrPassword) ? Properties.Settings.Default.usrPassword : EncriptionEngine.DecryptText(Properties.Settings.Default.usrPassword);
            private set
            {
                Properties.Settings.Default.usrPassword = string.IsNullOrEmpty(value) ? value : EncriptionEngine.EncryptText(value);
                Properties.Settings.Default.Save();
            }
        }

        public static bool IsSaved
        {
            get => Properties.Settings.Default.usrSaveCred;
            private set 
            { 
                Properties.Settings.Default.usrSaveCred = value;
                Properties.Settings.Default.Save();
            }
        }

        public static void SaveDefaultCredentials(string login, string password)
        {
            Login = login;
            Password = password;
            IsSaved = true;
            Properties.Settings.Default.Save();
        }

        public static void ClearDefaultCredentials()
        {
            SaveDefaultCredentials(null, null);
            IsSaved = false;
            Properties.Settings.Default.Save();
        }
    }
}

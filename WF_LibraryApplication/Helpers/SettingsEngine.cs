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

        public static string Server
        {
            get => Properties.Settings.Default.dbServer;
            private set
            {
                Properties.Settings.Default.dbServer = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string Database
        {
            get => Properties.Settings.Default.dbDatabase;
            private set
            {
                Properties.Settings.Default.dbDatabase = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string UserId
        {
            get => Properties.Settings.Default.dbUserId;
            private set
            {
                Properties.Settings.Default.dbUserId = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string UserPassword
        {
            get => String.IsNullOrEmpty(Properties.Settings.Default.dbPassword)? 
                Properties.Settings.Default.dbPassword : EncriptionEngine.DecryptText(Properties.Settings.Default.dbPassword);
            private set
            {
                Properties.Settings.Default.dbPassword = String.IsNullOrEmpty(value) ?
                    value : EncriptionEngine.EncryptText(value);
                Properties.Settings.Default.Save();
            }
        }


        public static bool IsSecured
        {
            get => Properties.Settings.Default.dbIsSecured;
            private set
            {
                Properties.Settings.Default.dbIsSecured = value;
                Properties.Settings.Default.Save();
            }
        }

        public static void SaveDbConfiguration(string server, string database, string user, string password, bool intSecurity)
        {
            Server = server;
            Database = database;
            UserId = intSecurity ? null : user;
            UserPassword = intSecurity ? null : password;
            IsSecured = intSecurity;
            Properties.Settings.Default.Save();
        }

    }
}

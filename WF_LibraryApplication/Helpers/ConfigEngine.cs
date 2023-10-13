using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using WF_LibraryApplication.Database;

namespace WF_LibraryApplication.Helpers
{
    internal class ConfigEngine
    {
        static Configuration config = 
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public static string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public static void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }

        public static void SaveConnectionString(string value)
        {
            SaveConnectionString(DatabaseManager.ConnectionStringDefaultKey, value);
        }

    }
}

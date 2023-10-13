using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WF_LibraryApplication.Helpers;

namespace WF_LibraryApplication.Database
{
    internal class DatabaseManager
    {
        //Sorted Procedure Names
        private static string spGetUserCredentials = "spGetUserCredentials";

        public static string ConnectionStringDefaultKey
        {
            get
            {
                return "CustomConnectionString";
            }
        }

        public static string CustomConnectionString(bool fromAppConfig = false)
        {
            if(fromAppConfig)
                return ConfigEngine.GetConnectionString(ConnectionStringDefaultKey);
            return BuildConnectionString(SettingsEngine.Server, SettingsEngine.Database,
            SettingsEngine.UserId, SettingsEngine.UserPassword, SettingsEngine.IsSecured);

        }

        private static string BuildConnectionString(string server, string database, 
            string userId, string password, bool integratedSecurity)
        {
            string connectionString = $@"Server={server};Database={database};";

            if (integratedSecurity)
                connectionString += @"Integrated Security=True;";
            else
                connectionString += $@"User Id={userId};Password={password};";

            return connectionString;
        }

        public static async Task<bool> TryConnectionAsync(string server, string database, 
            string userId, string password, bool integratedSecurity)
        {
            var connectionString = 
                BuildConnectionString(server, database, userId, password, integratedSecurity);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                    await connection.OpenAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static async Task<bool> TryEstablishConnectionAsync()
        {
            return await TryConnectionAsync(SettingsEngine.Server, SettingsEngine.Database,
                SettingsEngine.UserId, SettingsEngine.UserPassword, SettingsEngine.IsSecured);
        }
    }
}

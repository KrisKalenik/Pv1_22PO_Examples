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
        private static string spInsertUsersData = "spInsertUsersData";

        public static string ConnectionStringDefaultKey
        {
            get
            {
                return "CustomConnectionString";
            }
        }

        public static string LocalDbConnectionString
        {
            get
            {
                return ConfigEngine.GetConnectionString("WF_LibraryApplication.Properties.Settings.LocalDatabaseConnectionString");
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

        public static async Task<bool> CheckUserCredentialsAsync(string login, string password)
        {
            UserProfile.IsLoggedIn = false;

            using (var connection = new SqlConnection(CustomConnectionString(true)))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(spGetUserCredentials, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@login", login.Trim()));
                    command.Parameters.Add(new SqlParameter("@password", password.Trim()));
                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@fullName",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 20,
                        Direction = System.Data.ParameterDirection.Output
                    }) ;

                    using (var sqlDataReader = await command.ExecuteReaderAsync())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            //if (command.Parameters["@fullName"] != null)
                            //    UserProfile.FullName = 
                            //        command.Parameters["@fullName"].Value.ToString().Trim();

                            UserProfile.IsLoggedIn = true;
                            while(await sqlDataReader.ReadAsync())
                            {
                                UserProfile.AddNewRole(sqlDataReader.GetValue(0).ToString().Trim());
                            }
                        }
                        else
                        {
                            UserProfile.IsLoggedIn = false;
                        }
                    }

                }
            }

            return UserProfile.IsLoggedIn;

        }

        public static async Task<bool> InsertUserCredentials(string login, string password, 
            string fullName = null, string gender = null, Object birthday = null, string email = null, string phone = null,
            List<string> roles = null)
        {
            bool result = false;

            using (var connection = new SqlConnection(CustomConnectionString(true)))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(spInsertUsersData, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@login", login.Trim()),
                        new SqlParameter("@password", password.Trim()),
                        new SqlParameter("@fullName", fullName.Trim()),
                        new SqlParameter("@gender", gender.Trim()),
                        new SqlParameter("@birthday", birthday),
                        new SqlParameter("@email", email.Trim()),
                        new SqlParameter("@phone", phone.Trim()),
                        new SqlParameter("@roles", roles == null ? null : string.Join(",", roles))
                    }
                    );

                    int res = await command.ExecuteNonQueryAsync();
                    if (res > 0) result = true;

                }
            }

            return result;

        }

    }
}

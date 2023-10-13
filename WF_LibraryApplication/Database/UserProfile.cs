using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_LibraryApplication.Database
{
    internal class UserProfile
    {
        private static List<string> roles = new List<string>();

        public static bool IsLoggedIn { get; set; }
        public static string FullName { get; set; }

        public static List<string> Roles
        {
            get => roles;
            private set => roles = value;
        }

        public static void AddNewRole(string role)
        {
            if(string.IsNullOrEmpty(role))
                throw new ArgumentNullException("Role cannot be null or whitespace", nameof(role));
            if (role.Contains(role))
                throw new InvalidOperationException("This role already exists");
            roles.Add(role);
        }

    }
}

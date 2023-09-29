using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WF_LibraryApplication.Helpers
{
    internal class ValidationEngine
    {
        public static readonly String dateFormat = "dd.MM.yyyy";

        public static readonly CultureInfo culture = CultureInfo.InvariantCulture;

        private static string rgxStrLogin = @"^(?=.*[a-zA-Z0-9]$)[a-zA-Z][a-zA-Z\d.-_]{2,20}$";

        private static string rgxStrPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[\w@#!?$%&*]{8,20}$";

        private static string ValidateRequiredField(string value, string fieldName, string rgxStr, string invalidMessage)
        {
            if (string.IsNullOrWhiteSpace(value))
                return $"{fieldName} is required.";

            if (!Regex.IsMatch(value, rgxStr))
                return $"{fieldName} is invalid. \n{invalidMessage}";

            return null;
        }

        private static string ValidateOptionalField(string value, string fieldName, string rgxStr, string invalidMessage)
        {
            if (value != null && !Regex.IsMatch(value, rgxStr))
                return $"{fieldName} is invalid. \n{invalidMessage}";

            return null;
        }

        public static string ValidateLoginErrorMessage(string value)
        {
            return ValidateRequiredField(
                value,
                "Login",
                rgxStrLogin,
                "Required 2-20 characters, must start with a letter."
            );
        }

        public static string ValidatePasswordErrorMessage(string value)
        {
            return ValidateRequiredField(
                value,
                "Password",
                rgxStrPassword,
                "Required minimum 8 characters, \nat least one uppercase and lowercase letter, \nat least one number."
            );
        }


    }
}

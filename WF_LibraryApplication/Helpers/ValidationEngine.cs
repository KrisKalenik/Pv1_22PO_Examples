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
        public static readonly String DateFormat = "dd.MM.yyyy";

        public static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

        private static string rgxStrLogin = @"^(?=.*[a-zA-Z0-9]$)[a-zA-Z][a-zA-Z\d.-_]{2,20}$";

        private static string rgxStrPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[\w@#!?$%&*]{8,20}$";

        private static string rgxStrFullName = @"^$|^[a-zA-Z]{4,20}(?: [a-zA-Z]+){0,2}$";

        private static string rgxStrGender = @"^$|^M(ale)?$|^F(emale)?$";

        private static string rgxStrEmail = @"^$|^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        private static string rgxStrPhone = @"^$|^[\+]?[(]?[ ]{0,3}[)]?[ ]{0,3}$|^[\+]?[(]?[0-9]{2,3}[)]?[-\s\.]?[0-9]{2,3}[-\s\.]?[0-9]{2,6}$";

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

        public static string ValidatePasswordConfirmErrorMessage(string value, string password)
        {
            if (value != password)
                return "Password confirmation is invalid";
            return null;
        }

        public static string ValidateFullNameErrorMessage(string value)
        {
            return ValidateOptionalField(
                value,
                "Full name",
                rgxStrFullName,
                "It should consist of 4-20 alphabetical characters,\n" +
                "with optional space"
            );
        }

        public static string ValidateGendereErrorMessage(string value)
        {
            return ValidateOptionalField(
                value,
                "Gender",
                rgxStrGender,
                "It should be 'Male' or 'Female'"
            );
        }

        public static string ValidateBirthdayErrorMessage(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return null;

            if(!DateTime.TryParseExact(value, DateFormat, Culture, DateTimeStyles.None, out var birthday))
                return $"Invalid birthday format. Please use the format {DateFormat}.";

            var age = DateTime.Now.Year - birthday.Year;

            if (age < 0 || age > 150)
                return "Invalid age. Please enter a valid birthday.";

            return null;
        }

        public static string ValidateEmailErrorMessage(string value)
        {
            return ValidateOptionalField(
                value,
                "Email",
                rgxStrEmail,
                "It should follow the format 'name@example.com'"
            );
        }

        public static string ValidatePhoneErrorMessage(string value)
        {
            return ValidateOptionalField(
                value,
                "Phone",
                rgxStrPhone,
                "It should follow the format '+1234567890' or '+(123)1231313'."
            );
        }


    }
}

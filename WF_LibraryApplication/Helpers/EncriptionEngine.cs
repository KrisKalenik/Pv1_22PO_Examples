using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace WF_LibraryApplication.Helpers
{
    internal class EncriptionEngine
    {
        private const string DefaultPassword = "Password";

        public static string EncryptText(string text, string password = DefaultPassword)
        {
            using (var rijndaelManaged = new RijndaelManaged())
            {
                byte[] plainText = Encoding.Unicode.GetBytes(text);
                byte[] salt = Encoding.ASCII.GetBytes(password.Length.ToString());

                using (var secretKey = new PasswordDeriveBytes(password, salt))
                {
                    ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));

                    using (var memoryStream = new MemoryStream())
                    using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainText, 0, plainText.Length);
                        cryptoStream.FlushFinalBlock();

                        byte[] cipherBytes = memoryStream.ToArray();
                        return Convert.ToBase64String(cipherBytes);
                    }
                }
            }
        }

        public static string DecryptText(string encryptedText, string password = DefaultPassword)
        {
            using (var rijndaelManager = new RijndaelManaged())
            {
                byte[] encryptedData = Convert.FromBase64String(encryptedText);
                byte[] salt = Encoding.ASCII.GetBytes(password.Length.ToString());

                using (var secretKey = new PasswordDeriveBytes(password, salt))
                {
                    ICryptoTransform cryptoTransform = rijndaelManager.CreateDecryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));
                    using (var memoryStream = new MemoryStream(encryptedData))
                    using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
                    {
                        byte[] plainText = new byte[encryptedData.Length];
                        int decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);
                        return Encoding.Unicode.GetString(plainText, 0, decryptedCount);
                    }
                }
            }
        }

    }
}

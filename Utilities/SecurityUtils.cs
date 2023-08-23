using System.Security.Cryptography;
using System.Text;

namespace PasswordSaver.Utilities
{
    internal static class SecurityUtils
    {

        private static readonly byte[] Salt = "Next-Level.Games"u8.ToArray();

        public static string Encrypt(string password, string masterPassword)
        {
            var clearBytes = Encoding.Unicode.GetBytes(password);

            using var encryption = Aes.Create();

            Rfc2898DeriveBytes pdb = new(masterPassword, Salt);

            encryption.Key = pdb.GetBytes(32);
            encryption.IV = pdb.GetBytes(16);

            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, encryption.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(clearBytes, 0, clearBytes.Length);
                cs.Close();
            }

            password = Convert.ToBase64String(ms.ToArray());

            return password;
        }

        public static string Decrypt(string encrypted, string masterPassword)
        {
            encrypted = encrypted.Replace(" ", "+");

            var cipherBytes = Convert.FromBase64String(encrypted);

            using var encryption = Aes.Create();

            Rfc2898DeriveBytes pdb = new(masterPassword, Salt);

            encryption.Key = pdb.GetBytes(32);
            encryption.IV = pdb.GetBytes(16);

            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, encryption.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(cipherBytes, 0, cipherBytes.Length);
                cs.Close();
            }

            encrypted = Encoding.Unicode.GetString(ms.ToArray());

            return encrypted;
        }

        public static string GetHashValue(string password)
        {
            using var sha256 = SHA256.Create();

            var inputBytes = Encoding.UTF8.GetBytes(password);

            var hashBytes = sha256.ComputeHash(inputBytes);

            var hashedString = BitConverter.ToString(hashBytes).Replace("-", "");

            return hashedString;
        }
    }
}

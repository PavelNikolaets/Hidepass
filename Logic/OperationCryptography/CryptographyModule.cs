
using System.Security.Cryptography;
using System.Text;

namespace Hidepass.Logic.OperationCryptography
{
    internal class CryptographyModule
    {
        private static string GetComputerNameKey()
        {
            return Environment.MachineName;
        }

        private static byte[] DeriveKey(string key)
        {
            using var sha256 = SHA256.Create();
            return sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
        }

        public static string Encrypt(string plainText) //Шифрование
        {
            string key = GetComputerNameKey();
            byte[] keyBytes = DeriveKey(key);

            using Aes aes = Aes.Create();
            aes.Key = keyBytes;
            aes.GenerateIV();

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] encryptedData = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            byte[] result = new byte[aes.IV.Length + encryptedData.Length];
            Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
            Buffer.BlockCopy(encryptedData, 0, result, aes.IV.Length, encryptedData.Length);

            return Convert.ToBase64String(result);
        }

        public static string Decrypt(string cipherText) //Дешифрование
        {
            string key = GetComputerNameKey();
            byte[] keyBytes = DeriveKey(key);

            byte[] combinedData = Convert.FromBase64String(cipherText);

            int ivLength = 16;
            byte[] iv = new byte[ivLength];
            byte[] encryptedData = new byte[combinedData.Length - ivLength];

            Buffer.BlockCopy(combinedData, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(combinedData, iv.Length, encryptedData, 0, encryptedData.Length);

            using Aes aes = Aes.Create();
            aes.Key = keyBytes;
            aes.IV = iv;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            byte[] decryptedData = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);

            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}

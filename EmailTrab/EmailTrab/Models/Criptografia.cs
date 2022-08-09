
using System.Security.Cryptography;
using System.Text;
using XSystem.Security.Cryptography;
using ICryptoTransform = System.Security.Cryptography.ICryptoTransform;

namespace EmailTrab.Models
{
    public static class Criptografia
    {
        static string hash { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
        public static string Decriptor(string palavra )
        {
            byte[] data = Convert.FromBase64String(palavra); // decrypt the incrypted text
            using (XSystem.Security.Cryptography.MD5CryptoServiceProvider md5 = new XSystem.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    palavra = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return palavra;
        }
            public static string Encript(string palavra)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(palavra);
            using (XSystem.Security.Cryptography.MD5CryptoServiceProvider md5 = new XSystem.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    palavra = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return palavra;
        }
    }
}

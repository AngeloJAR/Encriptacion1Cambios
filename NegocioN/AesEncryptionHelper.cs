using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NegocioN
{
    public class AesEncryptionHelper
    {
        public static string Encrypt(string plainText, string password)
        {
            // Generar una clave derivada de la contraseña del usuario
            byte[] salt = Encoding.UTF8.GetBytes("tu_salt_aqui");
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] key = deriveBytes.GetBytes(32); // 32 bytes para una clave AES-256
                byte[] iv = deriveBytes.GetBytes(16); // 16 bytes para el vector de inicialización

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;

                    // Realizar la encriptación
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                    using (var msEncrypt = new System.IO.MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                            return Convert.ToBase64String(msEncrypt.ToArray());
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string password)
        {
            // Generar una clave derivada de la contraseña del usuario
            byte[] salt = Encoding.UTF8.GetBytes("tu_salt_aqui");
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] key = deriveBytes.GetBytes(32); // 32 bytes para una clave AES-256
                byte[] iv = deriveBytes.GetBytes(16); // 16 bytes para el vector de inicialización

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;

                    // Realizar la desencriptación
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
    }
}

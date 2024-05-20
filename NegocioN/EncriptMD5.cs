using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace NegocioN
{
    //md5 no es un algoritmo de cencriptacion Bidireccional si se quiere hacerlo bidireccional se necesita usar 
    public class EncriptMD5
    {
        public string Encrypt(string mensaje) 
        {
            
            byte[] data = Encoding.UTF8.GetBytes(mensaje);

            MD5 mD5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(mensaje));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        public string Decrypt(string mensajeEN) 
        {
            
            byte[] data = Convert.FromBase64String(mensajeEN);

            MD5 mD5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(mensajeEN));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace NegocioN
{
    public class EncriptSHA256
    {
        //SHA256 ES UN ALGORTIMO DE SIFRADO DE UNA SOLA DIRECCION ES DECIR
        //SI SE SIFRA ALGO NO SE PUEDE DECIFRAR SE LO PUEDE USAR PARA SIFRAR CLAVES
        //Q NO SE QUIERE MOSTRAR EN LA BASE DE DATOS :p
        public string EncryptSHA256(string mensaje)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                //Convertir el mensaje a byts
                byte[] hasgBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(mensaje));
                
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hasgBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
        
        public string DecryptSHA256(string mensaje)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                //Convertir el mensaje a byts
                byte[] hasgBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(mensaje));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hasgBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}

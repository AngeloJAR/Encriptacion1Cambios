using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NegocioN
{
    public class EncriptAES
    {
        public string EncriptAes(string mensaje, string clave)
        {
            //Convertir la clave ingresada a bytes, creamos un arreglo de bytes y lo usamos para la conversion de la clave a bytes
            byte[] claveBytes = Encoding.UTF8.GetBytes(clave);

            using (Aes aesAlg = Aes.Create())
            {
                //Se esctablece la clave ingresada para el algoritmo AES
                aesAlg.Key = claveBytes;
                //Se genera un vector de inicializacion aleatorio
                aesAlg.GenerateIV();

                //Creacion de objeto para cifrar el mensaje
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                //Convertir mensaje a bytes
                //Creacion de areglo el cual convierte el mensaje en bytes
                byte[] bytesMensaje = Encoding.UTF8.GetBytes(mensaje);
                //cifrar los bytes del mensaje 
                byte[] bytesCifrados = encryptor.TransformFinalBlock(bytesMensaje, 0, bytesMensaje.Length);
                //Concatenacion del vector de inicializacion al incio de los datos
                byte[] datosCifradosConIV = new byte[aesAlg.IV.Length + bytesCifrados.Length];
                Array.Copy(aesAlg.IV, 0, datosCifradosConIV, 0, aesAlg.IV.Length);
                Array.Copy(bytesCifrados, 0, datosCifradosConIV, aesAlg.IV.Length, bytesCifrados.Length);
                //Retonamos el mensaje cifrado como una cadena de base 64
                return Convert.ToBase64String(datosCifradosConIV);

            }
        }
        //metodo para decifra un mensaje encriptado mediante AES
        public string DecryptAes(string mensajeCifrado, string clave) 
        {
            //Convertir la clave proporcionada x el usuario a bytes
            byte[] claveBytes = Encoding.UTF8.GetBytes(clave);
            //Crear objeto AES para decifrar los datos
            using (Aes aesAlg = Aes.Create())
            {
                //Establecer la clave para el algoritmo AES
                aesAlg.Key = claveBytes;
                byte[] datosCifradosConIV = Convert.FromBase64String(mensajeCifrado);
                //Convertir el mensaje de base64 a bytes
                byte[] iv = new byte[aesAlg.IV.Length];
                Array.Copy(datosCifradosConIV, 0, iv, 0, aesAlg.IV.Length);
                aesAlg.IV = iv;
                //Crear un objeto para decencriptar el mensaje
                ICryptoTransform descryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                //Desifrar los bytes del mensaje
                byte[] bytesCifrados = new byte[datosCifradosConIV.Length - aesAlg.IV.Length];
                Array.Copy(datosCifradosConIV, aesAlg.IV.Length, bytesCifrados, 0, bytesCifrados.Length);
                byte[] bytesMensaje = descryptor.TransformFinalBlock(bytesCifrados, 0, bytesCifrados.Length);

                //devolvemos el mensaje decifrado
                return Encoding.UTF8.GetString(bytesMensaje);
            }
        }
       
    }
}

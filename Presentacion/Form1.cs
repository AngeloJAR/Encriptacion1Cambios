using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using NegocioN;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMostrarMensajeEncriptado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text; // Obtener la clave ingresada por el usuario
            string mensaje = txtMensaje.Text; // Obtener el mensaje ingresado por el usuario

            // Verificar si se ha ingresado una clave
            if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingresa una clave.");
                return;
            }

            // Encriptar el mensaje utilizando AES
            string mensajeEncriptado = AesEncryptionHelper.Encrypt(mensaje, clave);

            // Guardar la clave y el mensaje encriptado en la base de datos utilizando Entity Framework
            try
            {
                using (db_EncriptacionDesencriptacionEntities db = new db_EncriptacionDesencriptacionEntities())
                {
                    // Crear una instancia de la entidad MensajeEncriptado
                    MensajeEncriptado mensajeEncriptadoEntity = new MensajeEncriptado
                    {
                        ClaveEncriptada = clave,
                        MensajeEncriptado1 = mensajeEncriptado
                    };

                    // Agregar la entidad a la base de datos y guardar los cambios
                    db.MensajeEncriptado.Add(mensajeEncriptadoEntity);
                    db.SaveChanges();

                    MessageBox.Show("Mensaje encriptado y guardado exitosamente en la base de datos.");
                }
                txtMostrarMensajeEncriptado.Text = mensajeEncriptado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el mensaje encriptado en la base de datos: " + ex.Message);
            }
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text; // Obtener la clave ingresada por el usuario
            string mensajeEncriptado = txtMensaje.Text; // Obtener el mensaje encriptado

            // Verificar si se ha ingresado una clave
            if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingresa una clave.");
                return;
            }

            // Verificar si se ha ingresado un mensaje encriptado
            if (string.IsNullOrEmpty(mensajeEncriptado))
            {
                MessageBox.Show("No hay mensaje encriptado para desencriptar.");
                return;
            }

            // Desencriptar el mensaje utilizando la clave
            try
            {
                string mensajeDesencriptado = AesEncryptionHelper.Decrypt(mensajeEncriptado, clave);
                txtMensaje.Text = mensajeDesencriptado;
                MessageBox.Show("Mensaje desencriptado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desencriptar el mensaje: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
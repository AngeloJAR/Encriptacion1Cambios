using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using NegocioN;

namespace Presentacion
{
    public partial class Desencriptar : Form
    {
        public Desencriptar()
        {
            InitializeComponent();
        }

        private void Desencriptar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la clave ingresada por el usuario
            string claveIngresadaUsuario = ClaveEncriptada.Text; // Cambia ClaveEncriptada.Text por ClaveSinEncriptar.Text

            // Crear la conexión usando el contexto de Entity Framework
            using (db_EncriptacionDesencriptacionEntities db = new db_EncriptacionDesencriptacionEntities())
            {
                try
                {
                    var resultado = db.Database.SqlQuery<string>(
                        "ObtenerMensajePorClave @ClaveIngresada",
                        new SqlParameter("@ClaveIngresada", claveIngresadaUsuario)
                    ).FirstOrDefault();

                    if (!string.IsNullOrEmpty(resultado))
                    {
                        // Desencriptar el mensaje utilizando el método DecryptAes en tu código C#
                        EncriptAES encriptador = new EncriptAES();
                        try
                        {
                            // Utiliza la clave sin encriptar para desencriptar el mensaje
                            string mensajeDesencriptado = encriptador.DecryptAes(resultado, claveIngresadaUsuario);
                            MensajeDesencriptado.Text = mensajeDesencriptado;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al desencriptar: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta o no se encontró el mensaje asociado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error de conexión: {ex.Message}");
                }
            }
        }

        private void ClaveEncriptada_TextChanged(object sender, EventArgs e)
        {

        }

        private void MensajeDesencriptado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

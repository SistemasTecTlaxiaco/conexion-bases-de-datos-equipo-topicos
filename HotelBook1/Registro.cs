using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Entidades; // Tu clase Usuario

namespace HotelBook1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();
            string contraseñaIngresada = txtContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                MessageBox.Show("Por favor ingresa todos los campos.");
                return;
            }

            Usuario gestor = new Usuario();
            gestor.NUsuario = usuarioIngresado;

            // Obtener la contraseña encriptada desde la base de datos
            string contraseñaEncriptadaBD = gestor.ObtenerContraseñaDesdeBD();

            if (contraseñaEncriptadaBD == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }

            // Encriptar la contraseña ingresada para compararla
            string hashIngresado = EncriptarSHA256(contraseñaIngresada);

            if (hashIngresado == contraseñaEncriptadaBD)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                // Aquí puedes abrir la ventana principal
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
            }
        }

        private string EncriptarSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();

                foreach (var b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace HotelBook1
{
    public partial class panel : Form
    {
        
        Usuario gestor = new Usuario();

        public panel()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;

        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            // Crear el hilo para ejecutar el login
            Thread hiloLogin = new Thread(() => ValidarLogin(txtUsuario.Text, txtContraseña.Text));
            hiloLogin.IsBackground = true; // Agrega esto
            hiloLogin.Start();

        }
        private void ValidarLogin(string usuario, string contraseña)
        {
            try
            {
                string contraseñaHash = Utilidades.HashPassword(contraseña);
                bool acceso = gestor.Login(usuario, contraseñaHash);

                this.Invoke(new Action(() =>
                {
                    if (acceso)
                    {
                        MessageBox.Show("¡Bienvenido!");

                        Principal menu = new Principal();
                        menu.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Ocurrió un error al iniciar sesión: " + ex.Message);
                }));
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de registro
            Registro registro = new Registro();

            // Mostrar el formulario de registro como diálogo modal
            registro.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


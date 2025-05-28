using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // Hilos
using Entidades; // Librería con clase Usuario
using System.Security.Cryptography; // Encriptación

namespace HotelBook1
{
    public partial class Registro : Form
    {
        Usuario gestor = new Usuario(); // Gestor de usuarios

        public Registro()
        {
            InitializeComponent();
            txtcontraseña.UseSystemPasswordChar = true;
        }
      
        
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtcontraseña.Text))
            {
                MessageBox.Show("Por favor ingrese una contraseña", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcontraseña.Focus();
                return false;
            }

            return true;
        }

        // Registro en segundo plano (con encriptación)
        private void EjecutarRegistro(string usuario, string contraseña)
        {
            Usuario gestor = new Usuario();
            gestor.NUsuario = usuario;
            gestor.Contraseña = Utilidades.HashPassword(contraseña); // Encriptar aquí con nueva función

            bool exito = gestor.Registrar();

            _ = this.Invoke(new Action(() =>
            {
                if (exito)
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                    txtUsuario.Clear();
                    txtcontraseña.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario ya existe o hubo un error.");
                }

                btnResgistrar.Enabled = true;
            }));
        }
        private void btnResgistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            btnResgistrar.Enabled = false;

            // Lanza el registro en un hilo
            Thread hiloRegistro = new Thread(() =>
                EjecutarRegistro(txtUsuario.Text.Trim(), txtcontraseña.Text.Trim()));
            hiloRegistro.Start();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            int cursorPos = txtUsuario.SelectionStart;
            string textoFiltrado = new string(txtUsuario.Text
                .Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

            if (txtUsuario.Text != textoFiltrado)
            {
                txtUsuario.Text = textoFiltrado;
                txtUsuario.SelectionStart = cursorPos > 0 ? cursorPos - 1 : 0;

                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = txtcontraseña.Text;

            if (contraseña.Length >= 8)
            {
                bool tieneMayuscula = contraseña.Any(char.IsUpper);
                bool tieneMinuscula = contraseña.Any(char.IsLower);
                bool tieneNumero = contraseña.Any(char.IsDigit);
                bool tieneSimbolo = contraseña.Any(c => !char.IsLetterOrDigit(c));

                if (tieneMayuscula && tieneMinuscula && tieneNumero && tieneSimbolo)
                {
                    txtcontraseña.BackColor = Color.LightGreen;
                }
                else
                {
                    txtcontraseña.BackColor = Color.LightCoral;
                }
            }
            else
            {
                txtcontraseña.BackColor = Color.White;
            }
        }
    }
}

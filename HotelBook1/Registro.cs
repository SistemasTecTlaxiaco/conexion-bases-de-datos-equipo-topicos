using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;// Importamos la clase Thread para poder usar hilos
using Entidades; // Importamos la librería que contiene la clase Usuario

namespace HotelBook1
{
    public partial class Registro : Form


    {
        Usuario gestor = new Usuario();// Creamos un objeto gestor para manejar el registro de usuarios
        public Registro()
        {
            InitializeComponent();
            txtcontraseña.UseSystemPasswordChar = true;
        }




        // Validar campos del formulario
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(lbContraseña.Text))
            {
                MessageBox.Show("Por favor ingrese una contraseña", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbContraseña.Focus();
                return false;
            }

            return true;
        }

        // Método para ejecutar el registro en segundo plano
        private void EjecutarRegistro(string usuario, string contraseña)
        {
            // Siempre crea un nuevo objeto Usuario
            Usuario gestor = new Usuario();
            gestor.NUsuario = usuario;
            gestor.Contraseña = contraseña;

            // Verifica que los datos se estén pasando correctamente
            MessageBox.Show($"Registrando usuario: {gestor.NUsuario}\nContraseña: {gestor.Contraseña}");

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

            // Filtramos el texto para que solo queden letras y espacios
            string textoFiltrado = new string(txtUsuario.Text
                .Where(c => char.IsLetter(c) || char.IsWhiteSpace(c))
                .ToArray());

            if (txtUsuario.Text != textoFiltrado)
            {
                txtUsuario.Text = textoFiltrado;

                // Restauramos la posición del cursor al final del texto válido
                txtUsuario.SelectionStart = cursorPos > 0 ? cursorPos - 1 : 0;

                // Opcional: mostrar mensaje solo una vez por modificación
                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = txtcontraseña.Text;

            // Validar solo si tiene exactamente 8 caracteres
            if (contraseña.Length == 8)
            {
                bool tieneMayuscula = contraseña.Any(char.IsUpper);
                bool tieneNumero = contraseña.Any(char.IsDigit);

                if (tieneMayuscula && tieneNumero)
                {
                    txtcontraseña.BackColor = Color.LightGreen; // Contraseña válida
                }
                else
                {
                    txtcontraseña.BackColor = Color.LightCoral; // Contraseña inválida
                    MessageBox.Show("La contraseña debe contener al menos una letra mayúscula y un número.",
                        "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Si no tiene exactamente 8 caracteres, color neutro
                txtcontraseña.BackColor = Color.White;
            }
        }

    }
    }


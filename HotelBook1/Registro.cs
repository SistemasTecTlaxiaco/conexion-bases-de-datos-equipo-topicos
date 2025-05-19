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
        }



        // Método que valida los campos del formulario
        private bool ValidarCampos()
        {
            // Verifica si el campo de usuario está vacío
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus(); // Coloca el cursor en el campo vacío
                return false;
            }

            // Verifica si la contraseña está vacía
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingrese una contraseña", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }

           

            // Si todo está correcto, devuelve true
            return true;
        }
        // Método que ejecuta el proceso de registro en segundo plano

        private void EjecutarRegistro(string usuario, string contraseña)
        {
            // Asignamos los valores a las propiedades del objeto
            gestor.NUsuario = usuario;
            gestor.Contraseña = contraseña;

            // Llamamos al método Registrar sin parámetros
            bool exito = gestor.Registrar();

            this.Invoke(new Action(() =>
            {
                if (exito)
                {
                    MessageBox.Show("Usuario registrado correctamente.");
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
            // Primero validamos los campos
            if (!ValidarCampos()) return;

            // Deshabilitamos el botón para evitar clics múltiples
            btnResgistrar.Enabled = false;

            // Creamos un nuevo hilo para ejecutar el registro
            Thread hiloRegistro = new Thread(() => EjecutarRegistro(txtUsuario.Text, txtContraseña.Text));
            hiloRegistro.Start(); // Iniciamos el hilo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBook1
{
    public partial class Principal : Form
    {
        private Panel panel; // Agregar una referencia de objeto para el panel  

        public Principal()
        {
            InitializeComponent();
            this.Text = "Sistema de Gestión de Reservas";
            this.WindowState = FormWindowState.Maximized; // ✔ Correcto // Maximizar ventana  

            // Inicializar el panel  
            panel = new Panel();
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
        }

        // Método para abrir formularios hijos en el panel principal  
        private void AbrirFormulario(Form formularioHijo)
        {
            // Cerrar formulario anterior si existe  
            if (panel.Controls.Count > 0)
                panel.Controls[0].Dispose();

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formularioHijo);
            panel.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Reserva frm = new Reserva();
            AbrirFormulario(frm);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarReserva frm = new ConsultarReserva();
            AbrirFormulario(frm);
        }

        private void btnCancerlar_Click(object sender, EventArgs e)
        {
            CancelarReserva frm = new CancelarReserva();
            AbrirFormulario(frm);
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones frm = new Habitaciones();
            AbrirFormulario(frm);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

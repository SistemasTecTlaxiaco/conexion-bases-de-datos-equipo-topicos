using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HotelBook1
{
    public partial class Principal : Form
    {
        private Panel panel; // Agregar una referencia de objeto para el panel  

        public Principal()
        {
            InitializeComponent();
           
        }
      



        private void btnReserva_Click(object sender, EventArgs e)
        {
           

            Reserva reserva= new Reserva();
            reserva.ShowDialog();
            // Mostrar el formulario de registro como diálogo modal

            // O usa this.Close() si quieres cerrarlo completamente
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarReserva Creserva= new ConsultarReserva();
            Creserva.ShowDialog();
            // O usa this.Close() si quieres cerrarlo completamente
        }

        private void btnCancerlar_Click(object sender, EventArgs e)
        {
            CancelarReserva Clreserva= new CancelarReserva();
            Clreserva.ShowDialog();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones frm = new Habitaciones();
            frm.ShowDialog();
            
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

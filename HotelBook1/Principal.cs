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
            
        
        }

        private void btnCancerlar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CosultarReservas R = new CosultarReservas();
            R.Show();
        }
    }
}

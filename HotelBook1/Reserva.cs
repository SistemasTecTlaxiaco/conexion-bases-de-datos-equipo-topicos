using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace HotelBook1
{
    public partial class Reserva : Form
    {
        Reservas nuevaReserva = new Reservas();
        public Reserva()
        {
            InitializeComponent();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            {
                // Asignar valores
                nuevaReserva.Cliente = txtCliente.Text;
                nuevaReserva.FechaEntrada = dtpEntrada.Value;
                nuevaReserva.FechaSalida = dtpSalida.Value;
                nuevaReserva.Habitacion = cmbHabitacion.Text;
                nuevaReserva.NumeroPersonas = (int)numPersonas.Value;

                // Registrar
                bool resultado = nuevaReserva.Registrar();

                if (resultado)
                {
                    MessageBox.Show("Reserva registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtCliente.Clear();
            cmbHabitacion.SelectedIndex = -1; // Cambiar Clear() por SelectedIndex = -1 para limpiar la selección  
            numPersonas.Value = 1;
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CosultarReservas R= new CosultarReservas();
            R.Show();

        }
    }
}


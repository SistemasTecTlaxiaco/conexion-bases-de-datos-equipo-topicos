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

        private void cmbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHabitacion.SelectedItem != null)
            {
                string habitacionSeleccionada = cmbHabitacion.SelectedItem.ToString();

                if (habitacionSeleccionada == "Individual")
                {
                    numPersonas.Maximum = 1; // Máximo 1 persona para individual
                }
                else if (habitacionSeleccionada == "Matrimonial")
                {
                    numPersonas.Maximum = 2; // Máximo 2 personas para matrimonial
                }
            }
    }

        private void numPersonas_ValueChanged(object sender, EventArgs e)
        {
            if (cmbHabitacion.SelectedItem != null)
            {
                string habitacion = cmbHabitacion.SelectedItem.ToString();

                if (habitacion == "Individual" && numPersonas.Value > 1)
                {
                    numPersonas.Value = 1;
                    MessageBox.Show("La habitación individual solo permite 1 persona", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (habitacion == "Matrimonial" && numPersonas.Value > 2)
                {
                    numPersonas.Value = 2;
                    MessageBox.Show("La habitación matrimonial solo permite 2 personas", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
    }




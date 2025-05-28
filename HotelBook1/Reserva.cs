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
             
            cmbHabitacion.DropDownStyle = ComboBoxStyle.DropDownList; // Solo selección
            CargarOpcionesHabitacion(); // Cargar "Individual" y "Matrimonial"
        }

        private void CargarOpcionesHabitacion()
        {
            cmbHabitacion.Items.Clear();
            cmbHabitacion.Items.Add("Individual");
            cmbHabitacion.Items.Add("Matrimonial");
            cmbHabitacion.SelectedIndex = -1;
        }

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
                    numPersonas.Maximum = 1;
                }
                else if (habitacionSeleccionada == "Matrimonial")
                {
                    numPersonas.Maximum = 2;
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de habitación válido.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbHabitacion.SelectedIndex = -1;
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

        private void txtCliente_TextChanged(object sender, EventArgs e)

        {
            int cursorPosition = txtCliente.SelectionStart;

            // Solo letras y espacios
            string filteredText = new string(txtCliente.Text
                .Where(c => char.IsLetter(c) || char.IsWhiteSpace(c))
                .ToArray());

            if (filteredText != txtCliente.Text)
            {
                txtCliente.Text = filteredText;
                txtCliente.SelectionStart = Math.Min(cursorPosition, txtCliente.Text.Length);
            }
        }


        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }




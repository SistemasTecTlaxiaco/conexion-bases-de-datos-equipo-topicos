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
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
            // Inicializar el ComboBox con tipos de habitación
            cmbHabitacion.Items.Add("Individual");
            cmbHabitacion.Items.Add("Doble");
            cmbHabitacion.Items.Add("Suite");
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombreCliente = txtNombreCliente.Text;
            DateTime fechaEntrada = dtpEntrada.Value;
            DateTime fechaSalida = dtpSalida.Value;
            string habitacion = cmbHabitacion.SelectedItem?.ToString(); // Verifica si hay un elemento seleccionado
            int numeroPersonas = (int)numPersonas.Value;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(nombreCliente))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente.");
                return;
            }

            if (habitacion == null)
            {
                MessageBox.Show("Por favor, seleccione una habitación.");
                return;
            }

            if (fechaSalida <= fechaEntrada)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada.");
                return;
            }

            if (numeroPersonas <= 0)
            {
                MessageBox.Show("El número de personas debe ser mayor que cero.");
                return;
            }

            // Aquí se podrían guardar los datos en una base de datos o procesarlos
            // Mostrar mensaje de éxito
            MessageBox.Show("Reserva realizada con éxito:\n\n" +
                            $"Cliente: {nombreCliente}\n" +
                            $"Entrada: {fechaEntrada.ToShortDateString()}\n" +
                            $"Salida: {fechaSalida.ToShortDateString()}\n" +
                            $"Habitación: {habitacion}\n" +
                            $"Personas: {numeroPersonas}");
        }
    }
    }


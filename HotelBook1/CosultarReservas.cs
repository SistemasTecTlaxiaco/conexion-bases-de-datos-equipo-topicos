using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace HotelBook1
{
    public partial class CosultarReservas : Form
    {
        public CosultarReservas()
        {
            InitializeComponent();
        }

        private void CosultarReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            // Cargar todas las reservas
            List<Reservas> lista = Reservas.ObtenerTodas();
            reserva.DataSource = lista;
            reserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 👉 Botón "Salir"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra esta ventana
        }

        // 👉 Botón "Nueva Reserva"
        private void btnnuevareserva_Click(object sender, EventArgs e)
        {
            // Abrir el formulario anterior o de nueva reserva
            RegistroReserva nuevaReserva = new RegistroReserva(); // Usa el nombre correcto del formulario
            nuevaReserva.Show();

            this.Close(); // Cierra la ventana actual si ya no se necesita
        }
    }
}

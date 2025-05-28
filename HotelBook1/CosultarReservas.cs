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
    public partial class CosultarReservas : Form
    {
        public CosultarReservas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarReservas();
        }
        private void CargarReservas()
        {
            // Obtiene las reservas usando el método ObtenerTodas()
            List<Reservas> lista = Reservas.ObtenerTodas();

            // Muestra la lista en el DataGridView
            reserva.DataSource = lista;

            // Opcional: Ajustar columnas automáticamente
            reserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CosultarReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

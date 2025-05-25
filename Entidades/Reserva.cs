using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


namespace Entidades
{
    public class Reservas
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Habitacion { get; set; }
        public int NumeroPersonas { get; set; }
        public bool Registrar()
        {
            // Siempre obtener una nueva conexión
            using (var conn = ConexionBD.ObtenerConexion())
            {
                try
                {
                    // Abrir la conexión solo si está cerrada
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    string query = "INSERT INTO Reservas (cliente, fecha_entrada, fecha_salida, habitacion, numero_personas) VALUES(@cliente, @fecha_entrada, @fecha_salida, @habitacion, @numero_personas)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cliente", Cliente);
                    cmd.Parameters.AddWithValue("@fecha_entrada", FechaEntrada);
                    cmd.Parameters.AddWithValue("@fecha_salida", FechaSalida);
                    cmd.Parameters.AddWithValue("@habitacion", Habitacion);
                    cmd.Parameters.AddWithValue("@numero_personas", NumeroPersonas);


                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
        }
        public static List<Reservas> ObtenerTodas()
        {
            List<Reservas> listaReservas = new List<Reservas>();

            using (var conn = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, cliente, fecha_entrada, fecha_salida, habitacion, numero_personas FROM Reservas";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Reservas r = new Reservas
                        {
                            Id = reader.GetInt32("id"),
                            Cliente = reader.GetString("cliente"),
                            FechaEntrada = reader.GetDateTime("fecha_entrada"),
                            FechaSalida = reader.GetDateTime("fecha_salida"),
                            Habitacion = reader.GetString("habitacion"),
                            NumeroPersonas = reader.GetInt32("numero_personas")
                        };

                        listaReservas.Add(r);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener reservas: " + ex.Message);
                }
            }

            return listaReservas;
        }
    }
}






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Entidades
{
    internal class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "server=localhost;database=hotel;user=root;password=;";

            try
            {
                MySqlConnection conn = new MySqlConnection(cadena);
                // Intentamos abrir la conexión aquí
                return conn; // Si todo va bien, se retorna la conexión abierta
            }
            catch (MySqlException ex)
            {

                {
                    Console.WriteLine("Error al conectar: " + ex.Message);
                    throw; // Lanza la excepción para que puedas verla en el depurador
                }
            }

        }
    }
}

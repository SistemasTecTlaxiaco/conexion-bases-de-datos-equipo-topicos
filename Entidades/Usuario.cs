using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Entidades
{

    public class Usuario
    {
        public string NUsuario { get; set; }
        public string Contraseña { get; set; }

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

                    string query = "INSERT INTO usuario (usuario, contraseña) VALUES (@usuario, @contraseña)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", NUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", Contraseña);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
        }

       


        public bool Login(string usuario, string contraseña)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND contraseña = @contraseña";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
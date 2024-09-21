using MySql.Data.MySqlClient;
using System;

namespace BackOffice
{
    public class Bdconexion
    {
        private string connectionString = "Server=localhost;Database=bdbandapp;Uid=SIGENadmin;Pwd=Q1w2e3r4$;";

        // Método para establecer la conexión a la base de datos
        public MySqlConnection GetConexion()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

        // Método para ejecutar un INSERT
        //La clase insert espera un string del tipo query que contiene la consulta en este caso insert para la base de datos
        public bool Insert(string query)
        {
            using (var conexion = GetConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        //mysqlcommand es una clase proporcionada por mysql data para ejecutar una consulta, ademas juntamos la consulta y la conexion a la bd
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        int columnasAfectadas = cmd.ExecuteNonQuery();
                        return columnasAfectadas > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error al ejecutar el INSERT: " + ex.Message);
                        return false;
                    }
                }
                return false;
            }
        }

        // Método para ejecutar un UPDATE
        //espera el query que es un string con la consulta que la mandamos a traves del codigo
        public bool ExecuteUpdate(string query)
        {
            using (var connection = GetConexion())
            {
                if (connection != null)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int columnasAfectadas = cmd.ExecuteNonQuery();
                        return columnasAfectadas > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error al ejecutar el UPDATE: " + ex.Message);
                        return false;
                    }
                }
                return false;
            }
        }

        // Método para ejecutar un SELECT y devolver los resultados
        //espera la query para hacer la consulta
        public MySqlDataReader ExecuteSelect(string query)
        {
            var connection = GetConexion();
            if (connection != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader contenido = cmd.ExecuteReader();
                    return contenido;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error al ejecutar el SELECT: " + ex.Message);
                    return null;
                }
            }
            return null;
        }
    }
}


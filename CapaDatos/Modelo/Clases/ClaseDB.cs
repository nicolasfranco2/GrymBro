using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Asegúrate de tener el espacio de nombres correcto para tu base de datos

namespace CapaDatos.Modelo.Clases
{
    public class ClaseDB
    {
        // Método para obtener todas las clases desde la base de datos
        public List<Clase> ObtenerClases()
        {
            List<Clase> clases = new List<Clase>();

            // Cadena de conexión a tu base de datos
            string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10;";

            // Consulta SQL para seleccionar las clases
            string query = "SELECT ClaseID, NombreClase, InstructorID, Horario FROM clase";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre la conexión con la base de datos

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        // Ejecutar el comando y obtener el resultado en un DataReader
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Crear una nueva clase con los datos de la base de datos
                                Clase clase = new Clase
                                {
                                    ClaseID = reader.GetInt32(reader.GetOrdinal("ClaseID")),
                                    NombreClase = reader.GetString(reader.GetOrdinal("NombreClase")),
                                    InstructorID = reader.GetInt32(reader.GetOrdinal("InstructorID")),
                                    Horario = reader.GetString(reader.GetOrdinal("Horario"))
                                };

                                clases.Add(clase); // Agregar la clase a la lista
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones (si ocurre algún error)
                    Console.WriteLine("Error al obtener las clases: " + ex.Message);
                }
            }

            return clases;
        }

        // Método para insertar una nueva clase en la base de datos
        public void InsertarClase(Clase nuevaClase)
        {
            string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10;";
            string query = "INSERT INTO Clases (NombreClase, InstructorID, Horario) VALUES (@NombreClase, @InstructorID, @Horario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre la conexión con la base de datos

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Definir los parámetros para la consulta
                        command.Parameters.AddWithValue("@NombreClase", nuevaClase.NombreClase);
                        command.Parameters.AddWithValue("@InstructorID", nuevaClase.InstructorID);
                        command.Parameters.AddWithValue("@Horario", nuevaClase.Horario);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones (si ocurre algún error)
                    Console.WriteLine("Error al insertar la clase: " + ex.Message);
                }
            }
        }
    }
}

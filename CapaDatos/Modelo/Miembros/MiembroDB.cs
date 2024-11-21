using System;
using System.Collections.Generic;
using Npgsql; // Usar Npgsql para PostgreSQL
using CapaDatos.Modelo.Miembros;

namespace CapaDatos.Modelo.Miembros
{
    public class MiembroDB
    {
        // Método para obtener todos los miembros desde la base de datos
        public List<Miembro> ObtenerMiembros()
        {
            List<Miembro> miembros = new List<Miembro>();

            // Cadena de conexión a tu base de datos PostgreSQL
            string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10;";

            // Consulta SQL para seleccionar los miembros
            string query = "SELECT MiembroID, Nombre, Apellido, Correo, Telefono, TipoMembresia, FechaRegistro FROM miembro";

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
                                // Crear un nuevo miembro con los datos de la base de datos
                                Miembro miembro = new Miembro
                                {
                                    MiembroID = reader.GetInt32(reader.GetOrdinal("MiembroID")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                    Correo = reader.GetString(reader.GetOrdinal("Correo")),
                                    Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                                    TipoMembresia = reader.GetString(reader.GetOrdinal("TipoMembresia")),
                                    FechaRegistro = reader.GetDateTime(reader.GetOrdinal("FechaRegistro"))
                                };

                                miembros.Add(miembro); // Agregar el miembro a la lista
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones (si ocurre algún error)
                    Console.WriteLine("Error al obtener los miembros: " + ex.Message);
                }
            }

            return miembros;
        }
    }
}

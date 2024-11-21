using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Modelo.Pagos
{
    public class PagoDB
    {
        // Método para obtener los pagos desde la base de datos
        public List<Pago> ObtenerPagos()
        {
            List<Pago> pagos = new List<Pago>();

            // Cadena de conexión a tu base de datos
            string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10;";

            // Consulta SQL para seleccionar los pagos
            string query = "SELECT PagoID, MiembroID, FechaPago, Monto, MetodoPago FROM pago ";

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
                                // Crear un nuevo pago con los datos de la base de datos
                                Pago pago = new Pago
                                {
                                    PagoID = reader.GetInt32(reader.GetOrdinal("PagoID")),
                                    MiembroID = reader.GetInt32(reader.GetOrdinal("MiembroID")),
                                    FechaPago = reader.GetDateTime(reader.GetOrdinal("FechaPago")),
                                    Monto = reader.GetDecimal(reader.GetOrdinal("Monto")),
                                    MetodoPago = reader.GetString(reader.GetOrdinal("MetodoPago"))
                                };

                                pagos.Add(pago); // Agregar el pago a la lista
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones (si ocurre algún error)
                    Console.WriteLine("Error al obtener los pagos: " + ex.Message);
                }
            }

            return pagos;
        }
    }
}

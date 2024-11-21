using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo.Clases
{
    public class InstructorService
    {
        private string _connectionString;

        public InstructorService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<KeyValuePair<int, string>> ObtenerInstructores()
        {
            List<KeyValuePair<int, string>> instructores = new List<KeyValuePair<int, string>>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT empleadoid, nombre || ' ' || apellido AS nombrecompleto FROM public.empleado";

                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombreCompleto = reader.GetString(1);
                        instructores.Add(new KeyValuePair<int, string>(id, nombreCompleto));
                    }
                }
            }

            return instructores;
        }
    }
}
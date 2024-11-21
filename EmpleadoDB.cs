using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace Modelo.Empleados
{

	public class EmpleadoDB
{
	private string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10;";

	public List<Empleado> ObtenerEmpleados()
	{
		List<Empleado> empleados = new List<Empleado>();

		try
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT empleadoid, nombre, apellido, rol, horario, usuarioid FROM empleado";
				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					using (NpgsqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							empleados.Add(new Empleado
							{
								EmpleadoID = reader.GetInt32(0),
								Nombre = reader.GetString(1),
								Apellido = reader.GetString(2),
								Rol = reader.GetString(3),
								Horario = reader.IsDBNull(4) ? null : reader.GetString(4),
								UsuarioID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5)
							});
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error al obtener empleados: " + ex.Message);
		}

		return empleados;
	}
}

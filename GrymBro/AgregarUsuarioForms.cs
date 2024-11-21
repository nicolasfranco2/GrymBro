using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrymBro
{
    public partial class AgregarUsuarioForms : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10";

        public AgregarUsuarioForms()
        {
            InitializeComponent();
        }

        private void AgregarUsuarioForms_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

        }
        private void CargarUsuarios()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("select * from usuario;", connection))
                using (var reader = command.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    dgvUsuarios.DataSource = dataTable;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Obtener datos de los TextBoxes
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Encriptar la contraseña antes de almacenarla
            string contraseñaEncriptada = BCrypt.Net.BCrypt.HashPassword(contraseña);

            // Insertar usuario en la base de datos
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO public.usuario (usuarionombre, contraseña, nombre, apellido) 
            VALUES (@usuario, @contraseña, @nombre, @apellido)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    // Asignar parámetros
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);

                    try
                    {
                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario agregado correctamente.");
                            CargarUsuarios(); // Actualizar la lista de usuarios
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el usuario.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}");
                    }
                }
            }
        }
    }
}

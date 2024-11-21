using CapaDatos.Modelo.Clases;
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
    public partial class AgendarClase : Form
    {
        public AgendarClase()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Lógica del evento
        }

        private void btnGuardarClase_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10";

            string nombreClase = txtNombreClase.Text.Trim();
            int instructorId = ((KeyValuePair<int, string>)cmbInstructor.SelectedItem).Key; // ID del instructor seleccionado
            string horario = txtHorario.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreClase) || string.IsNullOrWhiteSpace(horario))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }

            using (var connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO public.clase (nombreclase, instructorid, horario)
        VALUES (@nombreclase, @instructorid, @horario)";

                using (var command = new Npgsql.NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreclase", nombreClase);
                    command.Parameters.AddWithValue("@instructorid", instructorId);
                    command.Parameters.AddWithValue("@horario", horario);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Clase cargada correctamente.");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cargar la clase.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
        private void LimpiarCampos()
        {
            txtNombreClase.Clear();
            txtHorario.Clear();
            cmbInstructor.SelectedIndex = -1;
            txtNombreClase.Focus();
        }

        private void cmbInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInstructor.SelectedItem != null)
            {
                // Obtenemos el instructor seleccionado
                var selectedInstructor = (KeyValuePair<int, string>)cmbInstructor.SelectedItem;

                // Obtenemos el ID del instructor
                int instructorId = selectedInstructor.Key;
                string instructorName = selectedInstructor.Value;

                // Mostramos el ID del instructor y el nombre completo
                MessageBox.Show($"ID del Instructor: {instructorId}\nNombre del Instructor: {instructorName}");
            }
        }

        private void AgendarClase_Load(object sender, EventArgs e)
        {
            // Cargar instructores al cargar el formulario
            // Crear una instancia del servicio de instructores
            InstructorService instructorService = new InstructorService("Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10");

            // Cargar instructores al cargar el formulario
            List<KeyValuePair<int, string>> instructores = instructorService.ObtenerInstructores();

            // Verifica si hay instructores disponibles
            if (instructores.Count > 0)
            {
                cmbInstructor.DataSource = instructores;
                cmbInstructor.DisplayMember = "Value"; // Muestra el nombre completo
                cmbInstructor.ValueMember = "Key"; // Usa el ID del instructor
            }
            else
            {
                cmbInstructor.Enabled = false;
                MessageBox.Show("No hay instructores disponibles.");
            }


        }
    }
}
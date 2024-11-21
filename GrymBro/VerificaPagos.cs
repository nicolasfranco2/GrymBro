using CapaDatos.Modelo.Pagos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrymBro
{
    public partial class VerificaPagos : Form
    {
        public VerificaPagos()
        {
            InitializeComponent();
        }

        private void VerificaPagos_Load(object sender, EventArgs e)
        {
            CargarPagos();

        }// Método para cargar los pagos desde la base de datos en el DataGridView
        private void CargarPagos()
        {
            PagoDB pagoDB = new PagoDB();
            List<Pago> pagos = pagoDB.ObtenerPagos();

            // Asignar la lista de pagos al DataGridView
            dataGridViewPagos.DataSource = pagos;

            // Opcional: configurar los encabezados de columna si es necesario
            dataGridViewPagos.Columns["PagoID"].HeaderText = "ID Pago";
            dataGridViewPagos.Columns["MiembroID"].HeaderText = "ID Miembro";
            dataGridViewPagos.Columns["FechaPago"].HeaderText = "Fecha de Pago";
            dataGridViewPagos.Columns["Monto"].HeaderText = "Monto";
            dataGridViewPagos.Columns["MetodoPago"].HeaderText = "Método de Pago";
        }

        // Este evento se ejecuta cuando se presiona el botón de verificación
        private void btnVerificarPago_Click(object sender, EventArgs e)
        {
            // Obtener el ID del pago seleccionado en el DataGridView
            if (dataGridViewPagos.SelectedRows.Count > 0)
            {
                int pagoID = (int)dataGridViewPagos.SelectedRows[0].Cells["PagoID"].Value;

                // Actualizar el estado del pago a "Verificado"
                VerificarPago(pagoID);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pago para verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para verificar el pago en la base de datos
        private void VerificarPago(int pagoID)
        {
            string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10;";

            // Consulta SQL para actualizar el estado del pago
            string query = "UPDATE Pagos SET MetodoPago = 'Verificado' WHERE PagoID = @PagoID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametrizar el valor de PagoID
                        command.Parameters.AddWithValue("@PagoID", pagoID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pago verificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPagos(); // Recargar los pagos para reflejar el cambio
                        }
                        else
                        {
                            MessageBox.Show("No se pudo verificar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
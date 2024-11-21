using CapaDatos.Modelo.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Importa el namespace correcto

namespace GrymBro
{
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();
        }

        private void ConsultaEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGrid();

        }
        private void CargarDatosEnDataGrid()
        {
            EmpleadoDB empleadoDB = new EmpleadoDB();
            List<Empleado> empleados = empleadoDB.ObtenerEmpleados();

            if (empleados.Count == 0)
            {
                MessageBox.Show("No hay datos de empleados en la base de datos.");
                return;
            }

            // Asignar la lista al DataGridView
             dataGridViewEmpleados.DataSource = empleados;

             // Opcional: Configurar columnas del DataGridView
             dataGridViewEmpleados.Columns["EmpleadoID"].HeaderText = "ID";
             dataGridViewEmpleados.Columns["Nombre"].HeaderText = "Nombre";
             dataGridViewEmpleados.Columns["Apellido"].HeaderText = "Apellido";
             dataGridViewEmpleados.Columns["Rol"].HeaderText = "Rol";
             dataGridViewEmpleados.Columns["Horario"].HeaderText = "Horario";
             dataGridViewEmpleados.Columns["UsuarioID"].HeaderText = "ID Usuario";
         }
 

            private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }
        }

    } 
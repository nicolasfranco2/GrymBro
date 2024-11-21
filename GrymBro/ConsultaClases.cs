using CapaDatos.Modelo.Clases;
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
    public partial class ConsultaClases : Form
    {
        public ConsultaClases()
        {
            InitializeComponent();
        }

        private void ConsultaClases_Load(object sender, EventArgs e)
        {
            CargarClases();

        }
        private void CargarClases()
        {
            // Crear una instancia de ClaseDB
            ClaseDB claseDB = new ClaseDB();

            // Obtener las clases desde la base de datos
            List<Clase> clases = claseDB.ObtenerClases();

            // Asignar las clases al DataGridView
            dataGridViewClases.DataSource = clases;

            // Opcional: configurar los encabezados de columna si es necesario
            dataGridViewClases.Columns["ClaseID"].HeaderText = "ID";
            dataGridViewClases.Columns["NombreClase"].HeaderText = "Nombre de Clase";
            dataGridViewClases.Columns["InstructorID"].HeaderText = "ID Instructor";
            dataGridViewClases.Columns["Horario"].HeaderText = "Horario";
        }
    }
}
    


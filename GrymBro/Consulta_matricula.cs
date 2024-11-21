using CapaDatos.Modelo.Miembros;
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
    public partial class Consulta_matricula : Form
    {
        public Consulta_matricula()
        {
            InitializeComponent();
        }
   
    private void Form1_Load(object sender, EventArgs e)
        {
            CargarMiembros();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    

    // Método para cargar los miembros en un DataGridView
    private void CargarMiembros()
    {
            // Crear una instancia de MiembroDB para obtener los miembros
            MiembroDB miembroDB = new MiembroDB();
            List<Miembro> miembros = miembroDB.ObtenerMiembros();

            // Asignar la lista de miembros al DataGridView
            dataGridViewMiembros.DataSource = miembros;

            // Opcional: configurar los encabezados de columna si es necesario
            dataGridViewMiembros.Columns["MiembroID"].HeaderText = "ID";
            dataGridViewMiembros.Columns["Nombre"].HeaderText = "Nombre";
            dataGridViewMiembros.Columns["Apellido"].HeaderText = "Apellido";
            dataGridViewMiembros.Columns["Correo"].HeaderText = "Correo";
            dataGridViewMiembros.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridViewMiembros.Columns["TipoMembresia"].HeaderText = "Tipo Membresía";
            dataGridViewMiembros.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
        }
}
}


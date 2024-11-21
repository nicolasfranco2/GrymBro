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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void elToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void consulteMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_matricula consultaMatricula = new Consulta_matricula();

            // Mostrar el formulario
            consultaMatricula.Show();
        }

        private void consultarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEmpleados consultaEmpleados = new ConsultaEmpleados();

            consultaEmpleados.Show();
        }

        private void consultarClasesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClases consultaClases = new ConsultaClases();

            consultaClases.Show();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuarioForms agregarUsuarioForms = new AgregarUsuarioForms();

            agregarUsuarioForms.Show();
        }

        private void verificarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificaPagos verificaPagos = new VerificaPagos();  

            verificaPagos.Show();  
        }

        private void agendarClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendarClase agendarClases = new AgendarClase();

            agendarClases.Show();
        }
    }
}

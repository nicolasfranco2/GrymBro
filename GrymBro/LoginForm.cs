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
using BCrypt.Net;
namespace GrymBro
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=gymbro;Username=postgres;Password=steamat10";
        public LoginForm()
        {
            InitializeComponent();
            login_button.Click += new EventHandler(login_button_Click);

        }
        private bool Autenticar(string usuario, string contraseña)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM Usuario WHERE UsuarioNombre = @usuario AND " +
                    "Contraseña = @contraseña", connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (Autenticar(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Aquí puedes redirigir a otra ventana o realizar otras acciones
                this.Hide(); // Oculta la ventana de inicio de sesión
                var inicioForm = new Inicio(); // Crea una nueva instancia de la ventana de inicio
                inicioForm.Show(); // Muestra la ventana de inicio
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
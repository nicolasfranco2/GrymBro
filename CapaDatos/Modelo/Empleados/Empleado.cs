using System;
namespace CapaDatos.Modelo.Empleados
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }
        public string Horario { get; set; }
        public int UsuarioID { get; set; }
    }
}
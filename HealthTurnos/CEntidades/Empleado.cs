using System;
using System.Collections.Generic;

namespace CEntidades
{
    public class Empleado
    {
        public static List<Empleado> listaEmpleados = new List<Empleado>();
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}

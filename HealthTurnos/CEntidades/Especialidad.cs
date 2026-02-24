using System.Collections.Generic;

namespace CEntidades
{
    public class Especialidad
    {
        public static List<Especialidad> listaEspecialidad = new List<Especialidad>();
        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
    }
}

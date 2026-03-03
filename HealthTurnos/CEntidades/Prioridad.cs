using System.Collections.Generic;

namespace CEntidades
{
    public class Prioridad
    {
        public static List<Prioridad> listaPrioridad = new List<Prioridad>();
        public int IdPrioridad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}

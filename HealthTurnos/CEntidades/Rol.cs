using System.Collections.Generic;

namespace CEntidades
{
    public class Rol
    {
        public static List<Rol> listaRoles = new List<Rol>();
        public int IdRol { get; set; }
        public string Nombre { get; set; }
    }
}

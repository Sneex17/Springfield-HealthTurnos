using System.Collections.Generic;

namespace CEntidades
{
    public class Asistente : Empleado
    {
        public static List<string> listaTurnos = new List<string>()
        { "Mañana", "Tarde", "Noche"};

        public static List<string> listaAreas = new List<string>()
        { "Urgencias", "Pediatría", "Cardiología", "Neurología", "Dermatología"};

        public string Turno { get; set; }
        public string Area { get; set; }
    }
}

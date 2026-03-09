using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.StatePattern;

namespace CEntidades.BuilderPattern
{
    public class Turno
    {
        public static List<Turno> listaTurnos = new List<Turno>();
        public int IdTurno { get; set; }
        public Character Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public Asistente Asistente { get; set; }
        public Medico Medico { get; set; }
        public string Observaciones { get; set; }
        public Prioridad Prioridad { get; set; }
        public EstadoTurno Estado { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CNegocio.StatePattern;

namespace CNegocio.BuilderPattern
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public Character Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public Medico Medico { get; set; }
        public string Observaciones { get; set; }
        public EstadoTurno Estado { get; set; }
    }
}

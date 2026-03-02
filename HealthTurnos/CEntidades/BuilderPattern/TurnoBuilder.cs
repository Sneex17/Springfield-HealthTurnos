using System;
using CEntidades.StatePattern;

namespace CEntidades.BuilderPattern
{
    public class TurnoBuilder : ITurnoBuilder
    {
        private readonly Turno _turno = new Turno();
        public ITurnoBuilder conIdTurno(int idturno)
        {
            _turno.IdTurno = idturno;
            return this;
        }
        public ITurnoBuilder conPaciente(Character paciente)
        {
            _turno.Paciente = paciente;
            return this;
        }
        public ITurnoBuilder conFecha(DateTime fecha)
        {
            _turno.Fecha = fecha;
            return this;
        }
        public ITurnoBuilder conMedico(Medico mediico)
        {
            _turno.Medico = mediico;
            return this;
        }
        public ITurnoBuilder conObservaciones(string observaciones)
        {
            _turno.Observaciones = observaciones;
            return this;
        }
        public ITurnoBuilder conEstado(EstadoTurno estado)
        {
            _turno.Estado = estado;
            return this;
        }
        public Turno CrearTurno()
        {
            return _turno;
        }
    }
}

using System;
using CEntidades.StatePattern;

namespace CEntidades.BuilderPattern
{
    public interface ITurnoBuilder
    {
        ITurnoBuilder conIdTurno(int idturno);
        ITurnoBuilder conPaciente(Character paciente);
        ITurnoBuilder conFecha(DateTime fecha);
        ITurnoBuilder conMedico(Medico mediico);
        ITurnoBuilder conObservaciones(string observaciones);
        ITurnoBuilder conEstado(EstadoTurno estado);
        Turno CrearTurno();
    }
}

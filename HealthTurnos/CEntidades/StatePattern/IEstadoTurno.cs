using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    public interface IEstadoTurno
    {
        int IdEstado { get; }
        string Estado { get; }
        void Pendiente(EstadoTurno estadoTurno);
        void EnAtencion(EstadoTurno estadoTurno);
        void Atendido(EstadoTurno estadoTurno);
        void Cancelado(EstadoTurno estadoTurno);
    }
}

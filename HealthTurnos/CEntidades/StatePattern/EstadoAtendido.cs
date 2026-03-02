namespace CEntidades.StatePattern
{
    public class EstadoAtendido : IEstadoTurno
    {
        public int IdEstado => 3;
        public string Estado => "Atendido";
        public void Pendiente(EstadoTurno estadoTurno) { }
        public void EnAtencion(EstadoTurno estadoTurno) { }

        public void Atendido(EstadoTurno estadoTurno) { }
        public void Cancelado(EstadoTurno estadoTurno) { }
    }
}

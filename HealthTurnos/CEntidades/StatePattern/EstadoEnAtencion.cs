namespace CEntidades.StatePattern
{
    public class EstadoEnAtencion : IEstadoTurno
    {
        public int IdEstado => 2;
        public string Estado => "En Atención";
        public void Pendiente(EstadoTurno estadoTurno) { }
        public void EnAtencion(EstadoTurno estadoTurno) { }

        public void Atendido(EstadoTurno estadoTurno)
        {
            estadoTurno.CambioEstado(new EstadoAtendido());
        }
        public void Cancelado(EstadoTurno estadoTurno) { }
    }
}

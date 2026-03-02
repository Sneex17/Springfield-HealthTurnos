namespace CEntidades.StatePattern
{
    public class EstadoPendiente : IEstadoTurno
    {
        public int IdEstado => 1;
        public string Estado => "Pendiente";
        public void Pendiente(EstadoTurno estadoTurno) { }
        public void EnAtencion(EstadoTurno estadoTurno)
        {
            estadoTurno.CambioEstado(new EstadoEnAtencion());
        }
        public void Atendido(EstadoTurno estadoTurno) { }

        public void Cancelado(EstadoTurno estadoTurno)
        {
            estadoTurno.CambioEstado(new EstadoCancelado());
        }
    }
}

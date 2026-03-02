namespace CNegocio.StatePattern
{
    public class EstadoCancelado : IEstadoTurno
    {
        public int IdEstado => 4;
        public string Estado => "Cancelado";
        public void Pendiente(EstadoTurno estadoTurno) { }
        public void EnAtencion(EstadoTurno estadoTurno) { }
        public void Atendido(EstadoTurno estadoTurno) { }
        public void Cancelado(EstadoTurno estadoTurno) { }
    }
}

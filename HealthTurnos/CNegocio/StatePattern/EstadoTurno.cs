namespace CNegocio.StatePattern
{
    public class EstadoTurno
    {
        public IEstadoTurno estado { get; private set; }

        public EstadoTurno()
        {
            estado = new EstadoPendiente();
        }

        public void CambioEstado(IEstadoTurno turno)
        {
            estado = turno;
        }

        public void Pendiente() => estado.Pendiente(this);
        public void EnAtencion() => estado.EnAtencion(this);
        public void Atendido() => estado.Atendido(this);
        public void Cancelado() => estado.Cancelado(this);
    }
}

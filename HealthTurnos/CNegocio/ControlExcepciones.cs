using System;

namespace CNegocio
{
    public class ControlExcepciones : Exception
    {
        public ControlExcepciones() { }
        public ControlExcepciones(string message) : base(message) { }
    } 
}

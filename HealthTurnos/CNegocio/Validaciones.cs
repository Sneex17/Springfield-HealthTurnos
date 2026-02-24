using CEntidades;
using FluentValidation;
using System;
using System.Security.Cryptography;
using CNegocio;

namespace CNegocio
{
    public class EmpleadoValidacion : AbstractValidator<Empleado>
    {
        public EmpleadoValidacion()
        {
            RuleFor(L => L.Nombre)
                .NotEmpty().WithMessage("El campo de nombre no puede estar vacío");
            RuleFor(L => L.Apellido)
               .NotEmpty().WithMessage("El campo de apellido no puede estar vacío");
            RuleFor(L => L.Telefono)
               .NotEmpty().WithMessage("El campo de telefóno no puede estar vacío");
            RuleFor(L => L.FechaIngreso)
                .LessThanOrEqualTo(DateTime.Today.AddDays(1)).WithMessage($"La fecha de ingreso debe ser menor o igual a la de hoy\n{DateTime.Today}");
        }
    }
}

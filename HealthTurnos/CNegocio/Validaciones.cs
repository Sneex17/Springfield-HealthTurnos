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

    public class MedicoValidacion : AbstractValidator<Medico>
    {
        public MedicoValidacion()
        {
            RuleFor(L => L.IdEmpleado)
               .NotEmpty().WithMessage("El campo de empleado no puede estar vacío");
            RuleFor(L => L.NroLicencia)
                .NotEmpty().WithMessage("El campo de N Licencia no puede estar vacío");
            RuleFor(L => L.IdEspecialidad)
               .NotEmpty().WithMessage("El campo de especialidad no puede estar vacío");
        }
    }

    public class AsistenteValidacion : AbstractValidator<Asistente>
    {
        public AsistenteValidacion()
        {
            RuleFor(L => L.IdEmpleado)
               .NotEmpty().WithMessage("El campo de empleado no puede estar vacío");
            RuleFor(L => L.Turno)
                .NotEmpty().WithMessage("El campo de turno no puede estar vacío");
            RuleFor(L => L.Area)
               .NotEmpty().WithMessage("El campo de área no puede estar vacío");
        }
    }

    public class UsuarioValidacion : AbstractValidator<Usuario>
    {
        public UsuarioValidacion()
        {
            RuleFor(L => L.Passwords)
               .NotEmpty().WithMessage("El campo de contraseña no puede estar vacío");
        }
    }
}

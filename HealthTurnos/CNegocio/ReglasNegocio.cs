using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos;
using CDatos.Controllers;

namespace CNegocio
{
    public class ReglasNegocio
    {
        public static List<Empleado> verEmpleados()
        {
            return EmpleadoController.VerEmpleados();
        }

        public static void RegistarEmpleado(Empleado empleado)
        {
            EmpleadoController.InsertarEmpeado(empleado);
        }

        public static void ActualizarEmpleado(Empleado empleado)
        {
            EmpleadoController.ActualizarEmpeado(empleado);
        }

        public static string GeneralEmail(string nombre, string apellido)
        {
            return $"{nombre.ToLower()}.{apellido.ToLower()}@HealthTurnos.com";
        }


    }


}

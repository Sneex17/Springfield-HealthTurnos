using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos;
using CDatos.Controllers;
using System.Data;

namespace CNegocio
{
    public class ReglasNegocio
    {
        //Empleados
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


        //Médicos
        public static DataTable verMedicos()
        {
            return MedicoController.VerMedicos();
        }
        



        //Especialidades
        public static List<Especialidad> VerEspecialidades()
        {
            return EspecialidadController.VerEspecialiad();
        }

    }


}

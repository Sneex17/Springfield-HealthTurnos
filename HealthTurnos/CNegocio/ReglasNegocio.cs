using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos;
using CDatos.Controllers;
using System.Data;
using CInfraestructura;
using System.Net.Http;

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
        public static void RegistarMedico(Medico medico)
        {
            MedicoController.InsertarMedico(medico);
        }
        public static void ActualizarMedico(Medico medico)
        {
            MedicoController.ActualizarMedico(medico);
        }

        //Asistentes
        public static DataTable verAsistentes()
        {
            return AsistenteController.VerAsistentes();
        }
        public static void RegistarAsistente(Asistente asistente)
        {
            AsistenteController.InsertarAsistente(asistente);
        }
        public static void ActualizarAsistente(Asistente asistente)
        {
            AsistenteController.ActualizarAsistente(asistente);
        }

        //Roles
        public static List<Rol> verRoles()
        {
            return RolesController.VerRolesUsuaio();
        }
        public static void RegistarRol(Rol rol)
        {
            RolesController.InsertarRol(rol);
        }
        public static void ActualizarRol(Rol rol)
        {
            RolesController.ActualizarRol(rol);
        }


        //Médicos
        public static DataTable verUsuarios()
        {
            return UsuarioController.VerUsuarios();
        }
        public static void RegistarUsuario(Usuario usuario)
        {
            UsuarioController.InsertarUsuario(usuario);
        }
        public static void ActualizarUsuario(Usuario usuario)
        {
            UsuarioController.ActualizarUsuario(usuario);
        }


        //Especialidades
        public static List<Especialidad> VerEspecialidades()
        {
            return EspecialidadController.VerEspecialiad();
        }
        public static void RegistarEspecialidad(Especialidad especialidad)
        {
            EspecialidadController.InsertarEspecialidad(especialidad);
        }
        public static void ActualizarEspecialidad(Especialidad especialidad)
        {
            EspecialidadController.ActualizarEspecialidad(especialidad);
        }

        public static async Task<List<Character>> VerPacientes()
        {
            IPacientesRepository repository = new PacientesApiRepository(new HttpClient());
            var services = new PacienteServices(repository);
            return await services.ObtenerPacientes();
        }

    }


}

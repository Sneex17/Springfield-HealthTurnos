using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using System.Data;

namespace CDatos.Controllers
{
    public class EmpleadoController
    {
        /// <summary>
        /// Método para obtener la lista de los empleados
        /// </summary>
        /// <returns>Devuelve una lista de empleados</returns>
        public static List<Empleado> VerEmpleados()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("spVerEmpleados", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Empleado.listaEmpleados.Add(new Empleado
                    {
                        IdEmpleado = leer.GetInt32(0),
                        Nombre = leer.GetString(1),
                        Apellido = leer.GetString(2),
                        Email = leer.GetString(3),
                        Telefono = leer.GetString(4),
                        FechaIngreso = leer.GetDateTime(5)
                    });
                }
                leer.Close();
            }
            return Empleado.listaEmpleados;
        }

        /// <summary>
        /// Método para registrar un nuevo empleado
        /// </summary>
        /// <param name="empleado">Recibe un objeto de tipo empleado</param>
        public static void InsertarEmpeado(Empleado empleado)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spInsertarEmpleado", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@Email", empleado.Email);
                comando.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                comando.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                resultado = comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar los datos de un empleado
        /// </summary>
        /// <param name="empleado">Recibe un objeto de tipo empleado</param>
        public static void ActualizarEmpeado(Empleado empleado)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spActualizarEmpleado", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@Email", empleado.Email);
                comando.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                comando.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}

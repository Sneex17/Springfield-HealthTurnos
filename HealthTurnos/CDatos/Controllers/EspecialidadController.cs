using System.Collections.Generic;
using System.Data.SqlClient;
using CEntidades;
using System.Data;

namespace CDatos.Controllers
{
    public class EspecialidadController
    {
        /// <summary>
        /// Método para obtener la lista de todas las especialidades
        /// </summary>
        /// <returns>Un lista de las especialidades</returns>
        public static List<Especialidad> VerEspecialiad()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("spVerEspecialidad", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Especialidad.listaEspecialidad.Add(new Especialidad
                    {
                        IdEspecialidad = leer.GetInt32(0),
                        Nombre = leer.GetString(1),
                        Salario = leer.GetDecimal(2)
                    });
                }
                leer.Close();
            }
            return Especialidad.listaEspecialidad;
        }
        /// <summary>
        /// Método para registrar una nueva especialidad
        /// </summary>
        /// <param name="especialidad">Recibe un objeto de tipo especialidad</param>
        public static void InsertarEspecialidad(Especialidad especialidad)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spInsertarEspecialidad", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", especialidad.Nombre);
                comando.Parameters.AddWithValue("@Salario", especialidad.Salario);
                resultado = comando.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Método para actualizar los datos de una especialidad
        /// </summary>
        /// <param name="especialidad">Recibe un objeto de tipo especialidad</param>
        public static void ActualizarEspecialidad(Especialidad especialidad)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spActualizarEspecialidad", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEspecialidad", especialidad.IdEspecialidad);
                comando.Parameters.AddWithValue("@Nombre", especialidad.Nombre);
                comando.Parameters.AddWithValue("@Salario", especialidad.Salario);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}

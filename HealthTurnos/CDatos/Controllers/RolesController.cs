using System.Collections.Generic;
using System.Data.SqlClient;
using CEntidades;
using System.Data;

namespace CDatos.Controllers
{
    public class RolesController
    {
        /// <summary>
        /// Método para obtener la lista de todos los roles de los usuarios
        /// </summary>
        /// <returns>Un lista de los roles</returns>
        public static List<Rol> VerRolesUsuaio()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("spVerRoles", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Rol.listaRoles.Add(new Rol
                    {
                        IdRol = leer.GetInt32(0),
                        Nombre = leer.GetString(1)
                    });
                }
                leer.Close();
            }
            return Rol.listaRoles;
        }

        /// <summary>
        /// Método para registrar un nuevo rol
        /// </summary>
        /// <param name="rol">Recibe un objeto de tipo rol</param>
        public static void InsertarRol(Rol rol)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spInsertarRol", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", rol.Nombre);
                resultado = comando.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Método para actualizar los datos de un rol
        /// </summary>
        /// <param name="rol">Recibe un objeto de tipo rol</param>
        public static void ActualizarRol(Rol rol)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spActualizarRol", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdRol", rol.IdRol);
                comando.Parameters.AddWithValue("@Nombre", rol.Nombre);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}

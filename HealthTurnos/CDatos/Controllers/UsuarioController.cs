using CEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CDatos.Controllers
{
    public class UsuarioController
    {
        /// <summary>
        /// Método para obtener la lista de todos los usuarios
        /// </summary>
        /// <returns>Un datatable de los usuarios</returns>
        public static DataTable VerUsuarios()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spVerUsuarios", acceso);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        /// <summary>
        /// Método para registrar un nuevo usuario
        /// </summary>
        /// <param name="usuario">Recibe un objeto de tipo usuario</param>
        public static void InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spInsertarUsuario", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", usuario.IdEmpleado);
                comando.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                comando.Parameters.AddWithValue("@Username", usuario.Username);
                comando.Parameters.AddWithValue("@Passwords", usuario.Passwords);
                resultado = comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar los datos de un usuario
        /// </summary>
        /// <param name="usuario">Recibe un objeto de tipo usuario</param>
        public static void ActualizarUsuario(Usuario usuario)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spActualizarUsuario", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                comando.Parameters.AddWithValue("@IdEmpleado", usuario.IdEmpleado);
                comando.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                comando.Parameters.AddWithValue("@Username", usuario.Username);
                comando.Parameters.AddWithValue("@Passwords", usuario.Passwords);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}

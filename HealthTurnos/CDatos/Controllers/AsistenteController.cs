using CEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CDatos.Controllers
{
    public class AsistenteController
    {
        /// <summary>
        /// Método para obtener la lista de todos los asistentes
        /// </summary>
        /// <returns>Un datatable de los asistentes</returns>
        public static DataTable VerAsistentes()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spVerAsistente", acceso);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        /// <summary>
        /// Método para registrar un nuevo asistente
        /// </summary>
        /// <param name="asistente">Recibe un objeto de tipo asistente</param>
        public static void InsertarAsistente(Asistente asistente)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spInsertarAsistente", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", asistente.IdEmpleado);
                comando.Parameters.AddWithValue("@IdEspecialidad", asistente.Turno);
                comando.Parameters.AddWithValue("@NroLicencia", asistente.Area);
                resultado = comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar los datos de un asistente
        /// </summary>
        /// <param name="asistente">Recibe un objeto de tipo asistente</param>
        public static void ActualizarAsistente(Asistente asistente)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spActualizarAsistente", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", asistente.IdEmpleado);
                comando.Parameters.AddWithValue("@IdEspecialidad", asistente.Turno);
                comando.Parameters.AddWithValue("@NroLicencia", asistente.Area);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}

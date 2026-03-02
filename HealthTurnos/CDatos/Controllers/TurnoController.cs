using CEntidades;
using CEntidades.BuilderPattern;
using System.Data;
using System.Data.SqlClient;

namespace CDatos.Controllers
{
    public class TurnoController
    {
        /// <summary>
        /// Método para obtener los turnos
        /// </summary>
        /// <returns>Un datatable con los turnos</returns>
        public static DataTable VerTurnos()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spListaTurnos", acceso);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        /// <summary>
        /// Método para registrar un nuevo turno
        /// </summary>
        /// <param name="turno">Recibe un objeto de tipo turno</param>
        public static void InsertarTurno(Turno turno)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spInsertarTurno", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdPaciente", turno.Paciente.id);
                comando.Parameters.AddWithValue("@Fecha", turno.Fecha);
                comando.Parameters.AddWithValue("@IdMedico", turno.Medico.IdEmpleado);
                comando.Parameters.AddWithValue("@Observaciones", turno.Observaciones);
                comando.Parameters.AddWithValue("@IdEstado", turno.Estado.estado.IdEstado);
                resultado = comando.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Método para actualizar los datos de un turno
        /// </summary>
        /// <param name="turno">Recibe un objeto de tipo turno</param>
        public static void ActualizarTurno(Turno turno)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spActualizarTurno", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdTurno", turno.IdTurno);
                comando.Parameters.AddWithValue("@Observaciones", turno.Observaciones);
                comando.Parameters.AddWithValue("@IdEstado", turno.Estado.estado.IdEstado);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}

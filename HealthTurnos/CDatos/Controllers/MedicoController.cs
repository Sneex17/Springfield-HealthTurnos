using CEntidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CDatos.Controllers
{
    public class MedicoController
    {
        /// <summary>
        /// Método para obtener la lista de todos los medicos
        /// </summary>
        /// <returns>Un datatable de los medicos</returns>
        public static DataTable VerMedicos()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spVerMedicos", acceso);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            } 
        }

        /// <summary>
        /// Método para registrar un nuevo medico
        /// </summary>
        /// <param name="medico">Recibe un objeto de tipo medico</param>
        public static void InsertarMedico(Medico medico)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spInsertarMedico", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", medico.IdEmpleado);
                comando.Parameters.AddWithValue("@IdEspecialidad", medico.IdEspecialidad);
                comando.Parameters.AddWithValue("@NroLicencia", medico.NroLicencia);
                resultado = comando.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Método para actualizar los datos de un medico
        /// </summary>
        /// <param name="medico">Recibe un objeto de tipo medico</param>
        public static void ActualizarMedico(Medico medico)
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                int resultado;
                SqlCommand comando = new SqlCommand("spActualizarMedico", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", medico.IdEmpleado);
                comando.Parameters.AddWithValue("@IdEspecialidad", medico.IdEspecialidad);
                comando.Parameters.AddWithValue("@NroLicencia", medico.NroLicencia);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}

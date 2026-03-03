using System.Collections.Generic;
using System.Data.SqlClient;
using CEntidades;
using System.Data;

namespace CDatos.Controllers
{
    public class PrioridadController
    {
        /// <summary>
        /// Método para obtener la lista de todas las prioridades de turnos
        /// </summary>
        /// <returns>Un lista de las prioridades</returns>
        public static List<Prioridad> VerRolesUsuaio()
        {
            using (SqlConnection acceso = ConexionBD.Instancia.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("spVerPrioridades", acceso);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Prioridad.listaPrioridad.Add(new Prioridad
                    {
                        IdPrioridad = leer.GetInt32(0),
                        Nombre = leer.GetString(1),
                        Descripcion = leer.GetString(2),
                    });
                }
                leer.Close();
            }
            return Prioridad.listaPrioridad;
        }
    }
}

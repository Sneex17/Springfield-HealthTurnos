using System.Collections.Generic;
using System.Data.SqlClient;
using CEntidades;
using System.Data;

namespace CDatos.Controllers
{
    public class EspecialidadController
    {
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
    }
}

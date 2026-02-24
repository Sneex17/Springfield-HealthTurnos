using CEntidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CDatos.Controllers
{
    public class MedicoController
    {
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
    }
}

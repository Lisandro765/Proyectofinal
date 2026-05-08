using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class ConexionBD
    {
        // La cadena de conexión se lee desde App.config (clave "AgendaDB")
        // para evitar valores fijos en el código fuente.
        private static string cadenaConexion =
            ConfigurationManager.ConnectionStrings["AgendaDB"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
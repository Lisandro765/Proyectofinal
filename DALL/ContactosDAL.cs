using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class ContactosDAL
    {
        public static bool Guardar(string nombre, string telefono,
                                   string correo, string direccion)
        {
            string query = @"INSERT INTO Contactos (Nombre, Telefono, Correo, Direccion) 
                             VALUES (@Nombre, @Telefono, @Correo, @Direccion)";

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
}



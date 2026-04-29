using System;
using System.Data;
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
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public static bool Eliminar(int idContacto)
        {
            string query = "DELETE FROM Contactos WHERE IdContacto = @Id";

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Id", idContacto);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public static bool Editar(int idContacto, string nombre, string telefono,
                                  string correo, string direccion)
        {
            string query = @"UPDATE Contactos
                             SET Nombre    = @Nombre,
                                 Telefono  = @Telefono,
                                 Correo    = @Correo,
                                 Direccion = @Direccion
                             WHERE IdContacto = @Id";

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Id", idContacto);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static DataTable ObtenerTodos()
        {
            string query = "SELECT IdContacto, Nombre, Telefono, Correo, Direccion FROM Contactos";

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

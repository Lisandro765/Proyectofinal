using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public static bool ExisteCorreo(string correo)
        {
            string query = "SELECT COUNT(*) FROM Contactos WHERE Correo = @Correo";
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Correo", correo);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public static bool ExisteCorreo(string correo, int idExcluir)
        {
            string query = "SELECT COUNT(*) FROM Contactos WHERE Correo = @Correo AND IdContacto <> @Id";
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Id", idExcluir);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public static bool ExisteTelefono(string telefono)
        {
            string query = "SELECT COUNT(*) FROM Contactos WHERE Telefono = @Telefono";
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public static bool ExisteTelefono(string telefono, int idExcluir)
        {
            string query = "SELECT COUNT(*) FROM Contactos WHERE Telefono = @Telefono AND IdContacto <> @Id";
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Id", idExcluir);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
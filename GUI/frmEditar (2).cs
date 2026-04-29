using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmEditar : Form
    {
        private int _id;

        public frmEditar(int id, string nombre, string telefono, string correo, string direccion)
        {
            InitializeComponent();
            _id = id;
            txtNombre.Text    = nombre;
            txtTelefono.Text  = telefono;
            txtCorreo.Text    = correo;
            txtDireccion.Text = direccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"UPDATE Contactos 
                                 SET Nombre = @Nombre, Telefono = @Telefono,
                                     Correo = @Correo, Direccion = @Direccion
                                 WHERE Id = @Id";

                using (SqlConnection con = ConexionBD.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id",        _id);
                    cmd.Parameters.AddWithValue("@Nombre",    txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono",  txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Correo",    txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

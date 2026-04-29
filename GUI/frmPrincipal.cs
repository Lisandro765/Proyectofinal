using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void CargarContactos()
        {
            dgvContactos.Rows.Clear();

            string query = "SELECT Id, Nombre, Telefono, Correo, Direccion FROM Contactos";

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvContactos.Rows.Add(
                        reader["Id"],
                        reader["Nombre"],
                        reader["Telefono"],
                        reader["Correo"],
                        reader["Direccion"]
                    );
                }
            }
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro ventanaRegistro = new frmRegistro();
            ventanaRegistro.StartPosition = FormStartPosition.CenterScreen;
            if (ventanaRegistro.ShowDialog() == DialogResult.OK)
                CargarContactos();
        }

        private void eliminarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un contacto de la tabla primero.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["id"].Value);
            string nombre = dgvContactos.CurrentRow.Cells["Nombres"].Value?.ToString();

            if (MessageBox.Show($"¿Eliminar el contacto \"{nombre}\"?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Contactos WHERE Id = @Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Contacto eliminado.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarContactos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un contacto de la tabla primero.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["id"].Value);
            string nombre = dgvContactos.CurrentRow.Cells["Nombres"].Value?.ToString();
            string telefono = dgvContactos.CurrentRow.Cells["Telefono"].Value?.ToString();
            string correo = dgvContactos.CurrentRow.Cells["correo"].Value?.ToString();
            string direccion = dgvContactos.CurrentRow.Cells["Dirección"].Value?.ToString();

            frmEditar ventanaEditar = new frmEditar(id, nombre, telefono, correo, direccion);
            ventanaEditar.StartPosition = FormStartPosition.CenterScreen;

            if (ventanaEditar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Contacto actualizado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarContactos();
            }
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
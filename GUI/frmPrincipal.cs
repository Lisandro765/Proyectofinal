using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void CargarContactos()
        {
            dgvContactos.Rows.Clear();

            string query = "SELECT Id, Nombre, Telefono, Correo, Direccion FROM Contactos";

            using (SqlConnection con = DAL.ConexionBD.ObtenerConexion())
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

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirRegistro();
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirRegistro();
        }

        private void AbrirRegistro()
        {
            frmRegistro ventanaRegistro = new frmRegistro();
            ventanaRegistro.StartPosition = FormStartPosition.CenterScreen;

            if (ventanaRegistro.ShowDialog() == DialogResult.OK)
            {
                CargarContactos();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }
}
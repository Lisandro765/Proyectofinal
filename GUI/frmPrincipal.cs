using System;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        // Tabla completa guardada en memoria para filtrar sin ir a BD
        private DataTable _tablaCompleta = new DataTable();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            CargarContactos();
        }

        // ── LISTAR ────────────────────────────────────────────────────────────
        private void CargarContactos()
        {
            try
            {
                _tablaCompleta = ContactosBLL.ObtenerTodos();
                dgvContactos.DataSource = _tablaCompleta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar contactos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── BUSCAR (filtra mientras se escribe) ───────────────────────────────
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filtro))
            {
                _tablaCompleta.DefaultView.RowFilter = "";
            }
            else
            {
                _tablaCompleta.DefaultView.RowFilter =
                    $"Nombre LIKE '%{filtro}%' OR " +
                    $"Telefono LIKE '%{filtro}%' OR " +
                    $"Correo LIKE '%{filtro}%' OR " +
                    $"Direccion LIKE '%{filtro}%'";
            }
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarContactos();
        }

        // ── CREAR ─────────────────────────────────────────────────────────────
        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro ventanaRegistro = new frmRegistro();
            ventanaRegistro.StartPosition = FormStartPosition.CenterScreen;
            if (ventanaRegistro.ShowDialog() == DialogResult.OK)
            {
                txtBuscar.Clear();
                CargarContactos();
            }
        }

        // ── ELIMINAR ──────────────────────────────────────────────────────────
        private void eliminarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un contacto de la tabla primero.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);
            string nombre = dgvContactos.CurrentRow.Cells["Nombre"].Value?.ToString();

            if (MessageBox.Show($"¿Eliminar el contacto \"{nombre}\"?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (ContactosBLL.Eliminar(id))
                {
                    MessageBox.Show("Contacto eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscar.Clear();
                    CargarContactos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── EDITAR ────────────────────────────────────────────────────────────
        private void editarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un contacto de la tabla primero.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);
            string nombre = dgvContactos.CurrentRow.Cells["Nombre"].Value?.ToString();
            string telefono = dgvContactos.CurrentRow.Cells["Telefono"].Value?.ToString();
            string correo = dgvContactos.CurrentRow.Cells["Correo"].Value?.ToString();
            string direccion = dgvContactos.CurrentRow.Cells["Direccion"].Value?.ToString();

            frmEditar ventanaEditar = new frmEditar(id, nombre, telefono, correo, direccion);
            ventanaEditar.StartPosition = FormStartPosition.CenterScreen;

            if (ventanaEditar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Contacto actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Clear();
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
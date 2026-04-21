using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        private int contadorId = 1;

        public frmPrincipal()
        {
            InitializeComponent();
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
                dgvContactos.Rows.Add(
                    contadorId++,
                    ventanaRegistro.NombrePersona,
                    ventanaRegistro.TelefonoPersona,
                    ventanaRegistro.CorreoPersona,
                    ventanaRegistro.DireccionPersona
                );
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvContactos.Refresh();
        }
    }
}
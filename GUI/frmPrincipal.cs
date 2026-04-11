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
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creamos la instancia de tu formulario de registro
            frmRegistro ventanaRegistro = new frmRegistro();

            // Esto hace que la ventana se abra centrada y no podás usar la de atrás hasta cerrar esta
            ventanaRegistro.StartPosition = FormStartPosition.CenterScreen;
            ventanaRegistro.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Esto cierra la pantalla principal y vuelve al Login (si lo configuraste así en Program.cs)
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aquí es donde llamarías a tu capa BLL para traer los datos
            // Por ahora, al menos limpia o refresca el control
            dgvContactos.Refresh();
        }
    }
}

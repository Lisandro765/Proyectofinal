using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEditar : Form
    {
        private int _id;

        public frmEditar(int id, string nombre, string telefono, string correo, string direccion)
        {
            InitializeComponent();
            _id = id;
            txtNombre.Text = nombre;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtDireccion.Text = direccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = ContactosBLL.Editar(
                    _id,
                    txtNombre.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtDireccion.Text.Trim()
                );

                if (resultado)
                {
                    MessageBox.Show("Contacto actualizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
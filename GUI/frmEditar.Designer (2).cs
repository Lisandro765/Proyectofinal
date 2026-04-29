namespace GUI
{
    partial class frmEditar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNombre    = new System.Windows.Forms.Label();
            this.lblTelefono  = new System.Windows.Forms.Label();
            this.lblCorreo    = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre    = new System.Windows.Forms.TextBox();
            this.txtTelefono  = new System.Windows.Forms.TextBox();
            this.txtCorreo    = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar   = new System.Windows.Forms.Button();
            this.btnCancelar  = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Text = "Nombre:";

            this.txtNombre.Location = new System.Drawing.Point(120, 17);
            this.txtNombre.Size = new System.Drawing.Size(230, 22);

            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(20, 55);
            this.lblTelefono.Text = "Teléfono:";

            this.txtTelefono.Location = new System.Drawing.Point(120, 52);
            this.txtTelefono.Size = new System.Drawing.Size(230, 22);

            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(20, 90);
            this.lblCorreo.Text = "Correo:";

            this.txtCorreo.Location = new System.Drawing.Point(120, 87);
            this.txtCorreo.Size = new System.Drawing.Size(230, 22);

            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 125);
            this.lblDireccion.Text = "Dirección:";

            this.txtDireccion.Location = new System.Drawing.Point(120, 122);
            this.txtDireccion.Size = new System.Drawing.Size(230, 22);

            this.btnGuardar.Location = new System.Drawing.Point(120, 165);
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnCancelar.Location = new System.Drawing.Point(220, 165);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.ClientSize = new System.Drawing.Size(380, 215);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar contacto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label    lblNombre;
        private System.Windows.Forms.Label    lblTelefono;
        private System.Windows.Forms.Label    lblCorreo;
        private System.Windows.Forms.Label    lblDireccion;
        private System.Windows.Forms.TextBox  txtNombre;
        private System.Windows.Forms.TextBox  txtTelefono;
        private System.Windows.Forms.TextBox  txtCorreo;
        private System.Windows.Forms.TextBox  txtDireccion;
        private System.Windows.Forms.Button   btnGuardar;
        private System.Windows.Forms.Button   btnCancelar;
    }
}

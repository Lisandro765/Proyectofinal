namespace GUI
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

      
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.id, this.Nombres, this.Telefono, this.correo, this.Dirección });
            this.dgvContactos.Location = new System.Drawing.Point(0, 31);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.RowTemplate.Height = 24;
            this.dgvContactos.Size = new System.Drawing.Size(800, 420);
            this.dgvContactos.TabIndex = 0;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentClick);

     
            this.id.HeaderText = "ID"; this.id.MinimumWidth = 6; this.id.Name = "id";
            this.Nombres.HeaderText = "Nombres"; this.Nombres.MinimumWidth = 6; this.Nombres.Name = "Nombres";
            this.Telefono.HeaderText = "Telefono"; this.Telefono.MinimumWidth = 6; this.Telefono.Name = "Telefono";
            this.correo.HeaderText = "correo"; this.correo.MinimumWidth = 6; this.correo.Name = "correo";
            this.Dirección.HeaderText = "Dirección"; this.Dirección.MinimumWidth = 6; this.Dirección.Name = "Dirección";

            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivosToolStripMenuItem,
                this.contactosToolStripMenuItem,
                this.aToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";

           
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cerrarSesiónToolStripMenuItem, this.salirToolStripMenuItem });
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.archivosToolStripMenuItem.Text = "Archivos";

            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);

            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.salirToolStripMenuItem.Text = "Salir";

            
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.verListadoToolStripMenuItem,
                this.registrarNuevoToolStripMenuItem,
                this.eliminarContactoToolStripMenuItem,
                this.editarContactoToolStripMenuItem });
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.contactosToolStripMenuItem.Text = "Contactos";

            this.verListadoToolStripMenuItem.Name = "verListadoToolStripMenuItem";
            this.verListadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verListadoToolStripMenuItem.Text = "Ver Listado";
            this.verListadoToolStripMenuItem.Click += new System.EventHandler(this.verListadoToolStripMenuItem_Click);

            this.registrarNuevoToolStripMenuItem.Name = "registrarNuevoToolStripMenuItem";
            this.registrarNuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarNuevoToolStripMenuItem.Text = "Registrar nuevo";
            this.registrarNuevoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoToolStripMenuItem_Click);

            // *** ELIMINAR - evento Click conectado ***
            this.eliminarContactoToolStripMenuItem.Name = "eliminarContactoToolStripMenuItem";
            this.eliminarContactoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarContactoToolStripMenuItem.Text = "Eliminar contacto";
            this.eliminarContactoToolStripMenuItem.Click += new System.EventHandler(this.eliminarContactoToolStripMenuItem_Click);

            // *** EDITAR - evento Click conectado ***
            this.editarContactoToolStripMenuItem.Name = "editarContactoToolStripMenuItem";
            this.editarContactoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarContactoToolStripMenuItem.Text = "Editar contacto";
            this.editarContactoToolStripMenuItem.Click += new System.EventHandler(this.editarContactoToolStripMenuItem_Click);

            // Ayuda
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.acercaDeToolStripMenuItem });
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.aToolStripMenuItem.Text = "Ayuda";

            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";

            // frmPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
    }
}

namespace GUI
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtusuario = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.Label();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            resources.ApplyResources(this.txtusuario, "txtusuario");
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.UseMnemonic = false;
            this.txtusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUsuario
            // 
            resources.ApplyResources(this.textUsuario, "textUsuario");
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            // 
            // txtcontraseña
            // 
            resources.ApplyResources(this.txtcontraseña, "txtcontraseña");
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // textContraseña
            // 
            resources.ApplyResources(this.textContraseña, "textContraseña");
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.WhatsApp_Image_2026_04_22_at_9_10_53_PM;
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.txtusuario);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtusuario;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label txtcontraseña;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button btnEntrar;
    }
}
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
            this.txtusuario.AutoSize = true;
            this.txtusuario.Location = new System.Drawing.Point(331, 57);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(54, 16);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.Text = "Usuario";
            this.txtusuario.UseMnemonic = false;
            this.txtusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(260, 88);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(170, 22);
            this.textUsuario.TabIndex = 1;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.AutoSize = true;
            this.txtcontraseña.Location = new System.Drawing.Point(309, 201);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(76, 16);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.Text = "Contraseña";
            this.txtcontraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(260, 263);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(170, 22);
            this.textContraseña.TabIndex = 3;
            this.textContraseña.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Lime;
            this.btnEntrar.Location = new System.Drawing.Point(303, 356);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(118, 43);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Iniciar sesión";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.WhatsApp_Image_2026_04_22_at_9_10_53_PM;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.txtusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "frmLogin";
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
namespace GUI
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.Guardar = new System.Windows.Forms.Button();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.textelefono = new System.Windows.Forms.TextBox();
            this.textdirreción = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.Lime;
            this.Guardar.Location = new System.Drawing.Point(186, 375);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(121, 51);
            this.Guardar.TabIndex = 5;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.button5_Click);
            // 
            // textcorreo
            // 
            this.textcorreo.Location = new System.Drawing.Point(127, 210);
            this.textcorreo.Multiline = true;
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(270, 40);
            this.textcorreo.TabIndex = 6;
            this.textcorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textelefono
            // 
            this.textelefono.Location = new System.Drawing.Point(127, 124);
            this.textelefono.Multiline = true;
            this.textelefono.Name = "textelefono";
            this.textelefono.Size = new System.Drawing.Size(270, 41);
            this.textelefono.TabIndex = 7;
            this.textelefono.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textdirreción
            // 
            this.textdirreción.Location = new System.Drawing.Point(127, 289);
            this.textdirreción.Multiline = true;
            this.textdirreción.Name = "textdirreción";
            this.textdirreción.Size = new System.Drawing.Size(270, 43);
            this.textdirreción.TabIndex = 8;
            this.textdirreción.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 31);
            this.textBox1.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(31, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(56, 16);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(31, 138);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(61, 16);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Location = new System.Drawing.Point(31, 213);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(48, 16);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.Text = "Correo";
            // 
            // txtDirección
            // 
            this.txtDirección.AutoSize = true;
            this.txtDirección.Location = new System.Drawing.Point(31, 292);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(64, 16);
            this.txtDirección.TabIndex = 14;
            this.txtDirección.Text = "Dirección";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textdirreción);
            this.Controls.Add(this.textelefono);
            this.Controls.Add(this.textcorreo);
            this.Controls.Add(this.Guardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.TextBox textelefono;
        private System.Windows.Forms.TextBox textdirreción;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtDirección;
    }
}
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
          
            if (textUsuario.Text == "admin" && textContraseña.Text == "123")
            {
                if (textUsuario.Text == "admin" && textContraseña.Text == "123")
                {
                    this.DialogResult = DialogResult.OK;  
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecta, fijate bien che.", "Error de acceso");
                }
            }
        }
            

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "admin" && textContraseña.Text == "123")
            {
                this.DialogResult = DialogResult.OK;  
                this.Close();                          
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta, fijate bien che.", "Error de acceso");
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


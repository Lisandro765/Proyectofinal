using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms; 

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Solo creamos el objeto del login, NO lo corremos con Application.Run todavía
            frmLogin login = new frmLogin();

            // 2. Usamos ShowDialog para que el programa se detenga aquí hasta que pongás la clave
            if (login.ShowDialog() == DialogResult.OK)
            {
                // 3. SI Y SOLO SI la clave fue "admin" y "123", abrimos el formulario principal
                Application.Run(new frmPrincipal());
            }
        }

    }
    }



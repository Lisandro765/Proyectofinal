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
            // Estas líneas configuran la parte visual
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Esto abre tu formulario de Login. 
            // Si te da error en 'frmLogin', revisá que se llame exactamente así en el explorador.
            Application.Run(new frmLogin());
        }
    }
}
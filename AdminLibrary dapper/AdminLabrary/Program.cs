using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.formularios.frmBuscar;
using AdminLabrary.formularios.principales;

namespace AdminLabrary
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin l = new frmLogin();
            l.Show();
            Application.Run();
        }
    }
}

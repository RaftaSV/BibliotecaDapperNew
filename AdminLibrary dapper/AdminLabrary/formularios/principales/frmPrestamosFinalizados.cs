using AdminLabrary.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.formularios.principales
{
    public partial class frmPrestamosFinalizados : Form
    {
        public frmPrestamosFinalizados()
        {
            InitializeComponent();
        }

        private void frmPrestamosFinalizados_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            CAlquileres alquileres = new CAlquileres();
            alquileresBindingSource.DataSource = alquileres.Listado();
            CLectores lec = new CLectores();
            CLibros libros = new CLibros();
            CAdministradores admin = new CAdministradores();
            librosBindingSource.DataSource = libros.Listado();
            lectoresBindingSource.DataSource = lec.Listado();
            administradoresBindingSource.DataSource = admin.Listado();
        }
    }
}

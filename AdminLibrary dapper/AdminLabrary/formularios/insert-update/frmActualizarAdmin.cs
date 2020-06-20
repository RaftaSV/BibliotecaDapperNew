using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.formularios.frmBuscar;

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmActualizarAdmin : Form
    {
        public entidades.Administradores A = new entidades.Administradores();
       
        public frmActualizarAdmin()
        {
            InitializeComponent();
          
        }

        private void frmActualizarAdmin_Load(object sender, EventArgs e)
        {
            administradoresBindingSource.DataSource = A;
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            administradoresBindingSource.EndEdit();
            entidades.Administradores ad = new entidades.Administradores();
            ad = (entidades.Administradores)administradoresBindingSource.Current;
            CAdministradores AD = new CAdministradores();
            AD.Actualizar(ad);
            frmPrincipal.admi.CargarDatos();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarLector lector = new frmBuscarLector();
            lector.enviar = 3;
            lector.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            administradoresBindingSource.EndEdit();
            entidades.Administradores ad = new entidades.Administradores();
            ad = (entidades.Administradores)administradoresBindingSource.Current;
            CAdministradores AD = new CAdministradores();
            AD.Eliminar(ad);
            frmPrincipal.admi.CargarDatos();
            this.Close();

        }
    }
}

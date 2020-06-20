using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.entidades;
using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using AdminLabrary.formularios.frmBuscar;

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmInsertarAdministrador : Form
    {
        public string Id;
        public frmInsertarAdministrador()
        {
            InitializeComponent();
            administradoresBindingSource.MoveLast();
            administradoresBindingSource.AddNew();
          
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            id_LectorTextBox.Text = Id;
           
            administradoresBindingSource.EndEdit();
            
                Administradores admi = new Administradores();
                admi = (Administradores)administradoresBindingSource.Current;
                CAdministradores cadmin = new CAdministradores();
                cadmin.guardar(admi);
                administradoresBindingSource.Clear();
                frmPrincipal.admi.CargarDatos();
                txtLecNombre.Text = "";
                this.Close();
            
        }

        private void frmInsertarAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarLector buscar = new frmBuscarLector();
            buscar.enviar = 2;
            buscar.ShowDialog();
        }

        private void lectorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_LectorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

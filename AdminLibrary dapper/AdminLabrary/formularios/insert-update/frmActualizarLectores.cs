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

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmActualizarLectores : Form
    {
        public entidades.Lectores lec = new entidades.Lectores();
        public frmActualizarLectores(entidades.Lectores lec)
        {
            InitializeComponent();
            this.lec = lec;
        }

        private void frmActualizarLectores_Load(object sender, EventArgs e)
        {
            lectoresBindingSource.DataSource = lec;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            entidades.Lectores lectores = new entidades.Lectores();
            lectoresBindingSource.EndEdit();
            lectores = (entidades.Lectores)lectoresBindingSource.Current;
            controladores.CLectores c = new controladores.CLectores();
            c.actualizar(lectores);
            frmPrincipal.lector.CargarDatos();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entidades.Lectores lectores = new entidades.Lectores();
            lectoresBindingSource.EndEdit();
            lectores = (entidades.Lectores)lectoresBindingSource.Current;
            controladores.CLectores c = new controladores.CLectores();
            c.Eliminar(lectores);
            frmPrincipal.lector.CargarDatos();
            this.Close();

        }
    }
}

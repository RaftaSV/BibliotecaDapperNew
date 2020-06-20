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
using AdminLabrary.formularios.insert_update;

namespace AdminLabrary.formularios.principales
{
    public partial class frmEditoriales : Form
    {
        public frmEditoriales()
        {
            InitializeComponent();
        }

        private void FpEditoriales_Load(object sender, EventArgs e)
        {
            CargarDatos();        
        }

       public void CargarDatos()
        {

            CEditoriales c = new CEditoriales();
            editorialesBindingSource.DataSource = c.Listado();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            frmInsertarEditorial f = new frmInsertarEditorial();
            f.ShowDialog();
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entidades.Editoriales editorial = new entidades.Editoriales();
            editorial = (entidades.Editoriales)editorialesBindingSource.Current;
            frmActualizarEditorial edi = new frmActualizarEditorial(editorial);
            edi.btnActualizareditorial.Enabled = true;
            edi.btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            edi.ShowDialog();
        }

        private void editorialesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            entidades.Editoriales editorial = new entidades.Editoriales();
            editorial = (entidades.Editoriales)editorialesBindingSource.Current;
            frmActualizarEditorial edi = new frmActualizarEditorial(editorial);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            edi.btnActualizareditorial.Enabled = false;
            edi.btnEliminar.Enabled = true;
            edi.ShowDialog();
        }

        private void editorialesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 
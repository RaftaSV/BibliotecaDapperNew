using AdminLabrary.conexion;
using AdminLabrary.entidades;
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
    public partial class frmActualizarEditorial : Form
    {

        public entidades.Editoriales Edi = new entidades.Editoriales();


        public frmActualizarEditorial(entidades.Editoriales Edi)
        {
            InitializeComponent();
            this.Edi = Edi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entidades.Editoriales editorial = new entidades.Editoriales();
            editorialesBindingSource.EndEdit();
            editorial = (entidades.Editoriales)editorialesBindingSource.Current;
            controladores.CEditoriales c = new controladores.CEditoriales();
            c.actualizar(editorial);
            frmPrincipal.editoriales.CargarDatos();
            this.Close();


        }

        private void FrmActualizarEditorial_Load(object sender, EventArgs e)
        {
            editorialesBindingSource.DataSource = Edi;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entidades.Editoriales editorial = new entidades.Editoriales();
            editorialesBindingSource.EndEdit();
            editorial = (entidades.Editoriales)editorialesBindingSource.Current;
            controladores.CEditoriales c = new controladores.CEditoriales();
            c.Eliminar(editorial);
            frmPrincipal.editoriales.CargarDatos();
            this.Close();
        }
    }
}

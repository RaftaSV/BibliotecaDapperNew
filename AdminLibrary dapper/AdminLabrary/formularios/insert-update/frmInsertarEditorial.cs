using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.controladores;
using AdminLabrary.entidades;
using AdminLabrary.formularios.principales;

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmInsertarEditorial : Form
    {
        public frmInsertarEditorial()
        {
            InitializeComponent();
        }

        private void frmInsertarEditorial_Load(object sender, EventArgs e)
        {
            editorialesBindingSource.MoveLast();
            editorialesBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editorialTextBox.Text!=""&&direccionTextBox.Text!="") {
                Editoriales edi = new Editoriales();
                CEditoriales edit = new CEditoriales();
                editorialesBindingSource.EndEdit();
                edi = (Editoriales)editorialesBindingSource.Current;
                edit.guardar(edi);
                editorialesBindingSource.Clear();
                frmPrincipal.editoriales.CargarDatos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }
    }
}

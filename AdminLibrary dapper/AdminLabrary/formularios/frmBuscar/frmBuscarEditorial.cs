using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.formularios.frmBuscar
{
    public partial class frmBuscarEditorial : Form
    {
        public int enviar;
      
        public frmBuscarEditorial()
        {
            InitializeComponent();
        }

        private void frmBuscarEditorial_Load(object sender, EventArgs e)
        {
            cargarLista();

            LinqL.filtroEdit();

        }
        void cargarLista()
        {
            CEditoriales c = new CEditoriales();
            editorialesBindingSource.DataSource = c.Listado();
            foreach (DataGridViewRow i in dtgEditoriales.Rows)
            {
                LinqL.edi.Add(new entidades.Editoriales {Id_Editorial = int.Parse(i.Cells[0].Value.ToString()), Editorial = i.Cells[1].Value.ToString(),Fundada = Convert.ToDateTime(i.Cells[2].Value.ToString()), Direccion = i.Cells[3].Value.ToString()});
            }
             
        }
        void seleccionar()
        {
            if (enviar == 1)
            {
                string id = dtgEditoriales.CurrentRow.Cells[0].Value.ToString();
                string nombre = dtgEditoriales.CurrentRow.Cells[1].Value.ToString();
                LinqL.nuevoL.id_EditorialTextBox.Text = id;
                LinqL.nuevoL.txtEditorial.Text = nombre;
                LinqL.nuevoL.id_Ed= id;
            }
            else
            {
                string id = dtgEditoriales.CurrentRow.Cells[0].Value.ToString();
                string nombre = dtgEditoriales.CurrentRow.Cells[1].Value.ToString();
                frmPrincipal.libros.nuevoLi.id_EditorialTextBox.Text = id;
                frmPrincipal.libros.nuevoLi.txtEditorial.Text = nombre;
                frmPrincipal.libros.nuevoLi.id_Ed = id;
            }
            this.Close();
        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LinqL.Buscar = txtBuscar.Text;
            LinqL.filtroEdit();

        }

        private void dtgEditoriales_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void dtgEditoriales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

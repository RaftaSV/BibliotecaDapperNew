using AdminLabrary.controladores;
using AdminLabrary.formularios.frmBuscar;
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

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmActualizarLibros : Form
    {
        public entidades.Libros li = new entidades.Libros();
        public string id_A;
        public string id_Ed;
        public frmActualizarLibros()
        {
            InitializeComponent();
        }

        private void frmActualizarLibros_Load(object sender, EventArgs e)
        {
            id_A = id_autorTextBox.Text;
            id_Ed = id_EditorialTextBox.Text;
            librosBindingSource.DataSource = li;
            CCategorias categorias = new CCategorias();
            categoriasBindingSource.DataSource = categorias.Listado();
        }
        private void btnAutor_Click(object sender, EventArgs e)
        {
            frmBuscarAutor f = new frmBuscarAutor();
            f.autor.Clear();
            f.Enviar = 2;
            id_EditorialTextBox.Text = id_Ed;
            f.ShowDialog();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            frmBuscarEditorial f = new frmBuscarEditorial();
            LinqL.edi.Clear();
            id_autorTextBox.Text = id_A;
            f.enviar = 2 ;
            f.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            id_autorTextBox.Text = id_A;
            id_EditorialTextBox.Text = id_Ed;
            librosBindingSource.EndEdit();
            entidades.Libros libro = new entidades.Libros();
            libro = (entidades.Libros)librosBindingSource.Current;
            CLibros l = new CLibros();
            l.Actualizar(libro);
            txtAutor.Text = "";
            txtEditorial.Text = "";
            id_A = "";
            id_Ed = "";
            frmPrincipal.libros.CargarDatos();
            this.Close();
        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            librosBindingSource.EndEdit();
            entidades.Libros libro = new entidades.Libros();
            libro = (entidades.Libros)librosBindingSource.Current;
            CLibros l = new CLibros();
            l.Eliminar(libro);
            frmPrincipal.libros.CargarDatos();
            this.Close();
        }
    }
}

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
using AdminLabrary.modelos;

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmInsertarLibro : Form
    {
        public frmInsertarLibro()
        {
            InitializeComponent();
        }
        public string id_A;
        public string id_Ed;
        private void frmInsertarLibro_Load(object sender, EventArgs e)
        {
            librosBindingSource.MoveLast();
            librosBindingSource.AddNew();
            CCategorias categorias = new CCategorias();
            categoriasBindingSource.DataSource = categorias.Listado();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text != "" && txtEditorial.Text != "" && id_autorTextBox.Text != "" && int.Parse(cantidadTextBox.Text) > 0 && añoDateTimePicker != null)
            {
                id_autorTextBox.Text = id_A;
                id_EditorialTextBox.Text = id_Ed;
                CLibros li = new CLibros();
                Libros libro = new Libros();
                librosBindingSource.EndEdit();
                libro = (Libros)librosBindingSource.Current;
                li.guardar(libro);
                librosBindingSource.MoveLast();
                librosBindingSource.AddNew();
                txtAutor.Text = "";
                txtEditorial.Text = "";
                id_A = "";
                id_Ed = "";
                frmPrincipal.libros.CargarDatos();

                this.Close();

            }
            else
            {
                MessageBox.Show("Todos los Campos son obligatorios");
            }


        }
        public frmBuscarAutor f = new frmBuscarAutor();
        private void btnAutor_Click(object sender, EventArgs e)
        {
            LinqL.autorL.Clear();
            f.Enviar = 1;
            id_EditorialTextBox.Text = id_Ed;
            f.ShowDialog();
        }

        public frmBuscarEditorial editorial = new frmBuscarEditorial();
        private void btnEditorial_Click(object sender, EventArgs e)
        {
            LinqL.edi.Clear();
            id_autorTextBox.Text = id_A;
            editorial.enviar = 1;
            editorial .ShowDialog();
        }

        private void id_EditorialLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

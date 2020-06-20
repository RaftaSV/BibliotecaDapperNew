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
    public partial class frmInsertarCategoria : Form
    {
        public frmInsertarCategoria()
        {
            InitializeComponent();
        }

        private void frmInsertarCategoria_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.MoveLast();
            categoriasBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (categoriaTextBox.Text!="") {
                Categorias categorias = new Categorias();
                CCategorias cCategorias = new CCategorias();
                categoriasBindingSource.EndEdit();
                categorias = (Categorias)categoriasBindingSource.Current;
                cCategorias.guardar(categorias);
                categoriasBindingSource.Clear();
                frmPrincipal.Categoria.CargarDatos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }
    }
}

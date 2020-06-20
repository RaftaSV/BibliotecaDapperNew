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
using AdminLabrary.formularios.insert_update;
using AdminLabrary.modelos;
using DnsClient.Protocol;

namespace AdminLabrary.formularios.principales
{
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        private void fpLibros_Load(object sender, EventArgs e)
        {
            CargarDatos();  
        }
        public void CargarDatos()
        {

            CEditoriales ed = new CEditoriales();
            CAutores au = new CAutores();
            CCategorias ca = new CCategorias();
            CLibros li = new CLibros();

            editorialesBindingSource.DataSource = ed.Listado();
            autoresBindingSource.DataSource = au.Listado();
            categoriasBindingSource.DataSource = ca.Listado();
            librosBindingSource.DataSource = li.Listado();
        }

        private void librosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            LinqL.nuevoL.ShowDialog();
        }

        public frmActualizarLibros nuevoLi = new frmActualizarLibros();
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nuevoLi.li =(entidades.Libros) librosBindingSource.Current;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            nuevoLi.btnActualizar.Enabled = true;
            nuevoLi.btnEliminar.Enabled = false;
            nuevoLi.btnEditorial.Enabled = true;
            nuevoLi.btnAutor.Enabled = true;
            nuevoLi.txtAutor.Text = librosDataGridView.CurrentRow.Cells[5].FormattedValue.ToString();
            nuevoLi.txtEditorial.Text = librosDataGridView.CurrentRow.Cells[6].FormattedValue.ToString();
            nuevoLi.ShowDialog();
        }

        private void librosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nuevoLi.li = (entidades.Libros)librosBindingSource.Current;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            nuevoLi.btnActualizar.Enabled = false;
            nuevoLi.btnEliminar.Enabled = true;
            nuevoLi.btnEditorial.Enabled = false;
            nuevoLi.btnAutor.Enabled = false;
            nuevoLi.txtAutor.Text = librosDataGridView.CurrentRow.Cells[5].FormattedValue.ToString();
            nuevoLi.txtEditorial.Text = librosDataGridView.CurrentRow.Cells[6].FormattedValue.ToString();
            nuevoLi.ShowDialog();
        }
    }
}

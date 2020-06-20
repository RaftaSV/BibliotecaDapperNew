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
using DnsClient.Protocol;

namespace AdminLabrary.formularios.principales
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void FpAutor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            CAutores c = new CAutores();
            autoresBindingSource.DataSource = c.Listado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarAutores f = new frmInsertarAutores();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            f.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entidades.Autores autor = new entidades.Autores();
            autor = (entidades.Autores)autoresBindingSource.Current;
            frmActualizarAutores aautor = new frmActualizarAutores(autor);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            aautor.btnEditar.Enabled = true;
            aautor.btnEliminar.Enabled = false;
            aautor.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entidades.Autores autor = new entidades.Autores();
            autor = (entidades.Autores)autoresBindingSource.Current;
            frmActualizarAutores aautor = new frmActualizarAutores(autor);
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            aautor.btnEditar.Enabled = false;
            aautor.btnEliminar.Enabled = true;
            aautor.ShowDialog();

        }

        private void autoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
}

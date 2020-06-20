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
    public partial class frmActualizarAutores : Form
    {
        public entidades.Autores AU = new entidades.Autores();
        public frmActualizarAutores(entidades.Autores AU)
        {
            InitializeComponent();
            this.AU = AU;
        }

        private void frmActualizarAutores_Load(object sender, EventArgs e)
        {
            autoresBindingSource.DataSource = AU;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entidades.Autores AUTOR = new entidades.Autores();
            autoresBindingSource.EndEdit();
            AUTOR = (entidades.Autores)autoresBindingSource.Current;
            controladores.CAutores c = new controladores.CAutores();
            c.actualizar(AUTOR);
            frmPrincipal.autor.CargarDatos();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entidades.Autores AUTOR = new entidades.Autores();
            autoresBindingSource.EndEdit();
            AUTOR = (entidades.Autores)autoresBindingSource.Current;
            controladores.CAutores c = new controladores.CAutores();
            c.Eliminar(AUTOR);
            frmPrincipal.autor.CargarDatos();
            this.Close();
        }
    }
}

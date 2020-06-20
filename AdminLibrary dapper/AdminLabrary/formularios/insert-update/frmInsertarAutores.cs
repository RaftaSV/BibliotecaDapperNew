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
using AdminLabrary.formularios;
using AdminLabrary.entidades;
using AdminLabrary.formularios.principales;

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmInsertarAutores : Form
    {
        public frmInsertarAutores()
        {
            InitializeComponent();
            autoresBindingSource.MoveLast();
            autoresBindingSource.AddNew();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(nombreTextBox.Text!=""&&nacionalidadTextBox.Text!="")
            {
                Autores Autor = new Autores();
                CAutores autor = new CAutores();
                autoresBindingSource.EndEdit();
                Autor = (Autores)autoresBindingSource.Current;
                autor.guardar(Autor);
                autoresBindingSource.Clear();
                frmPrincipal.autor.CargarDatos();
                this.Close();

            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }

        }

        private void frmInsertarAutores_Load(object sender, EventArgs e)
        {

        }
    }
}

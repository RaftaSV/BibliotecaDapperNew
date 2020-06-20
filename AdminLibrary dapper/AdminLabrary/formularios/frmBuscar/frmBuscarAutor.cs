using AdminLabrary.entidades;
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
using AdminLabrary.formularios.principales;
using AdminLabrary.modelos;

namespace AdminLabrary.formularios.frmBuscar
{
    public partial class frmBuscarAutor : Form
    {
       public List<entidades.Autores> autor = new List<entidades.Autores>();
        public int Enviar;
        public frmBuscarAutor()
        {
            InitializeComponent();
           
        }

   
        private void frmBuscarAutor_Load(object sender, EventArgs e)
        {
            CargarLista();
            LinqL.filtroAutores();
           

        }
        public void CargarLista()
        {
            CAutores au = new CAutores();
            autoresBindingSource.DataSource = au.Listado();
            int ID;
            foreach (DataGridViewRow i in dtgAutores.Rows)
            {
               
                autor.Add(new entidades.Autores { Id_autor = int.Parse(i.Cells[0].Value.ToString()), Nombre = i.Cells[1].Value.ToString(), fecha_nacimiento = Convert.ToDateTime(i.Cells[2].Value.ToString()), Nacionalidad = i.Cells[3].Value.ToString() });

            }

            LinqL.autorL = autor;
        }
        
        void seleccionar()
        {
            if(Enviar == 1)
            {
                string id = dtgAutores.CurrentRow.Cells[0].Value.ToString();
                string Nombre = dtgAutores.CurrentRow.Cells[1].Value.ToString();
                 LinqL.nuevoL.id_autorTextBox.Text = id;
                LinqL.nuevoL.txtAutor.Text = Nombre;
                LinqL.nuevoL.id_A = id;


            }
            else
            {
                string id = dtgAutores.CurrentRow.Cells[0].Value.ToString();
                string Nombre = dtgAutores.CurrentRow.Cells[1].Value.ToString();
                frmPrincipal.libros.nuevoLi.id_autorTextBox.Text = id;
                frmPrincipal.libros.nuevoLi.txtAutor.Text = Nombre;
                frmPrincipal.libros.nuevoLi.id_A = id;
            }
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LinqL.Buscar = txtBuscar.Text;
            LinqL.filtroAutores();
        }

        private void dtgAutores_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void dtgAutores_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

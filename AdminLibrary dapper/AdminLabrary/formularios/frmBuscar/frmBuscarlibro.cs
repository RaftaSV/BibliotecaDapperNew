using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.conexion;
using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using AdminLabrary.modelos;

namespace AdminLabrary.formularios.frmBuscar
{
    public partial class frmBuscarlibro : Form
    {
        public frmBuscarlibro()
        {
            InitializeComponent();
            
        }

           private void frmBuscarlibro_Load(object sender, EventArgs e)
        {
            

            cargar();
         
        }

       
       public void cargar()
        {
            CLibros cLibros = new CLibros();
            librosBindingSource.DataSource = cLibros.ListadoL();

            foreach (DataGridViewRow i in dgvLibros.Rows)
            {
                int id = int.Parse(i.Cells[0].Value.ToString());
                int cantidad = int.Parse(i.Cells[2].Value.ToString());

                if (cantidad > 0)
                {
                    LinqL.Libros.Add(new entidades.Libros { Id_libro = id, Nombre = i.Cells[1].Value.ToString(), cantidad = cantidad });
                }
            }
        }
       

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LinqL.Buscar = txtBuscar.Text;
            LinqL.filtroLibros();
        }

        private void dgvLibros_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }
        void seleccionar()
        {
            
            LinqL.Libros.Clear();
            
            string libro = dgvLibros.CurrentRow.Cells[1].Value.ToString();
            string id = dgvLibros.CurrentRow.Cells[0].Value.ToString();
            frmPrincipal.alquiler.txtLibro.Text = libro;
            frmPrincipal.alquiler.id_libroTextBox.Text = id;
            this.Close();
        }

        

        private void dgvLibros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

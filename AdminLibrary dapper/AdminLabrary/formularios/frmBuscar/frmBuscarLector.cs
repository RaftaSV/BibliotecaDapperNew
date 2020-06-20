using AdminLabrary.conexion;
using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using RazorEngine.Compilation.ImpromptuInterface;
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
    public partial class frmBuscarLector : Form
    {

        public List<entidades.Lectores> lector = new List<entidades.Lectores>();
        public List<entidades.Lectores> lector1 = new List<entidades.Lectores>();
        public List<entidades.Alquileres> lista = new List<entidades.Alquileres>();
        public int enviar;
        public frmBuscarLector()
        {
            InitializeComponent();
        }

        private void frmBuscarLector_Load(object sender, EventArgs e)
        {
            CargarLista();
            filtro();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            filtro();
        }


        private void seleccionar()
        {
            if (enviar == 1)
            {
                string Lector = dgvLectores.CurrentRow.Cells[1].Value.ToString();
                string id = dgvLectores.CurrentRow.Cells[0].Value.ToString();
                frmPrincipal.alquiler.txtLector.Text = Lector;
                frmPrincipal.alquiler.id_LectorTextBox.Text = id;
                this.Close();
            }
            else if (enviar == 2)
            {
                string Lector = dgvLectores.CurrentRow.Cells[1].Value.ToString();
                string id = dgvLectores.CurrentRow.Cells[0].Value.ToString();
                frmAdministradores.admin.id_LectorTextBox.Text = id;
                frmAdministradores.admin.txtLecNombre.Text = Lector;
                frmAdministradores.admin.Id = id;
                this.Close();

            }
            else if(enviar == 3)
            {
                string Lector = dgvLectores.CurrentRow.Cells[1].Value.ToString();
                string id = dgvLectores.CurrentRow.Cells[0].Value.ToString();
                frmPrincipal.admi.admiactualizar.id_LectorTextBox.Text = id;
                frmPrincipal.admi.admiactualizar.txtLecNombre.Text = Lector;
                this.Close();
            }

        }
        void CargarLista()
        {
            if (enviar == 1)
            {
                CLectores lec = new CLectores();
                lectoresBindingSource.DataSource = lec.Listado();
                int Id;
                foreach (DataGridViewRow i in dgvLectores.Rows)
                {
                    Id = int.Parse(i.Cells[0].Value.ToString());
                    lector1.Add(new entidades.Lectores { Id_Lector = Id, Nombres = i.Cells[1].Value.ToString(), Apellidos = i.Cells[2].Value.ToString() });
                }


                var listalec = from lect in lector1
                               select new
                               {

                                   idlec = lect.Id_Lector,
                                   NOMBRES = lect.Nombres,
                                   APELLIDOS = lect.Apellidos

                               };
                foreach (var i in listalec)
                {

                    var listaalq = from li in lista
                                   where li.Id_Lector == i.idlec
                                   select new
                                   {
                                       idlector = li.Id_Lector
                                   };

                    if (listaalq.Count() < 3)
                    {
                        lector.Add(new entidades.Lectores { Id_Lector = i.idlec, Nombres = i.NOMBRES, Apellidos = i.APELLIDOS });
                    }


                }


            }
            else
            {
                CLectores lec = new CLectores();
                lectoresBindingSource.DataSource = lec.ListadoparaAdmi();
                int Id;
                foreach (DataGridViewRow i in dgvLectores.Rows)
                {
                    Id = int.Parse(i.Cells[0].Value.ToString());
                    lector.Add(new entidades.Lectores { Id_Lector = Id, Nombres = i.Cells[1].Value.ToString(), Apellidos = i.Cells[2].Value.ToString() });
                }
            }

        }


        void filtro()
        {
            string buscar = txtBuscar.Text;
            var lista = from lec in lector
                        where lec.Nombres.Contains(buscar)
                        select new
                        {
                            Id_Lector = lec.Id_Lector,
                            NOMBRES = lec.Nombres,
                            APELLIDOS = lec.Apellidos
                        };

            dgvLectores.DataSource = lista.ToList();

        }

        private void frmBuscarLector_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }



        private void dgvLectores_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvLectores_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }
    }
}

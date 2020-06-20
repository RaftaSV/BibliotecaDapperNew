
using AventStack.ExtentReports.Gherkin.Model;
using System;



using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdminLabrary.formularios.insert_update;
using AdminLabrary.formularios.frmBuscar;

namespace AdminLabrary.formularios.principales
{

    public partial class frmPrincipal : Form
    {
        public static string Id;
        public frmPrincipal()
        {
            InitializeComponent();



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;


        public void MostrarPanel(Form Panel)
        {
            if (activeForm != null)

                activeForm = Panel;
            Panel.TopLevel = false;
            Panel.FormBorderStyle = FormBorderStyle.None;
            Panel.Dock = DockStyle.Fill;
            pPrincipal.Controls.Add(Panel);
            pPrincipal.Tag = Panel;
            Panel.BringToFront();
            mostrarmenu();
            Panel.Show();

        }



        public static frmEditoriales editoriales = new frmEditoriales();
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarPanel(editoriales);
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("¿Desea salir de la aplicacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resu == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        int estado = 0;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

            if (estado == 0)
            {

                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Visible = true;
                btnMinimizar.Visible = true;
                estado = 1;
            } else
            {
                this.WindowState = FormWindowState.Normal;
                btnMinimizar.Visible = true;
                btnMaximizar.Visible = true;
                estado = 0;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)

        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int lParam, int v);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        public static frmLectores lector = new frmLectores();
        private void btnLectores_Click(object sender, EventArgs e)
        {


            MostrarPanel(lector);

        }

        public static frmCategoria Categoria = new frmCategoria();
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            MostrarPanel(Categoria);
        }
        public static frmLibros libros = new frmLibros();
        private void btnLibros_Click(object sender, EventArgs e)
        {
            libros.CargarDatos();
            MostrarPanel(libros);
        }


        public static frmAutor autor = new frmAutor();
        private void btnAutor_Click(object sender, EventArgs e)
        {
            MostrarPanel(autor);
        }
        public static frmAdministradores admi = new frmAdministradores();
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MostrarPanel(admi);
        }
        public static frmAlquileres alquileres = new frmAlquileres();

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            MostrarPanel(alquileres);
        }

        int botonO = 0;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            mostrarmenu();
        }
        void mostrarmenu()
        {

            if (botonO == 0)
            {
                PanelMenu.Hide();
                btnMenu2.Show();
                botonO = 1;

            }
            else
            {
                PanelMenu.Show();
                botonO = 0;
                btnMenu2.Hide();
            }

        }
        public static frmRecibir recibir = new frmRecibir();
        public static frmInsertarAlquiler alquiler = new frmInsertarAlquiler();

        private void LogoGrande_Click(object sender, EventArgs e)
        {

        }

        private void pbtnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
 
        public static frmBuscarlibro buscarlibro = new frmBuscarlibro();
    }

}



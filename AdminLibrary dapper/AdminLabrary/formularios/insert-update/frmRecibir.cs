using AdminLabrary.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.formularios.principales
{
    public partial class frmRecibir : Form
    {
        public int id;
        public entidades.AlquileresPendientes a = new entidades.AlquileresPendientes();
        public frmRecibir()
        {
            InitializeComponent();
            
        }

        private void frmRecibir_Load(object sender, EventArgs e)
        {
            alquileresPendientesBindingSource.DataSource = a;



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            recibirTextBox.Text = id.ToString();
            alquileresPendientesBindingSource.EndEdit();
            entidades.AlquileresPendientes alq = new entidades.AlquileresPendientes();
            alq = (entidades.AlquileresPendientes)alquileresPendientesBindingSource.Current;
            CAlquileres cAlq = new CAlquileres();
            cAlq.Recibir(alq);
            alquileresPendientesBindingSource.Clear();
            txtLector.Text = "";
            txtLibro.Text = "";
            frmPrincipal.alquileres.CargarDatos();
            this.Close();
        }
    }
}

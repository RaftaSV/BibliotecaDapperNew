using AdminLabrary.controladores;
using AdminLabrary.entidades;
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
    public partial class frmInsertarLector : Form
    {
        Lectores lectores = new Lectores();
        public frmInsertarLector()
        {
            InitializeComponent();
            lectoresBindingSource.MoveLast();
            lectoresBindingSource.AddNew();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (nombresTextBox.Text != "" && apellidosTextBox.Text != "")
            {
                lectoresBindingSource.EndEdit();
                CLectores lec = new CLectores();
                lectores = (Lectores)lectoresBindingSource.Current;
                lec.guardar(lectores);
                lectoresBindingSource.Clear();
                frmPrincipal.lector.CargarDatos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios","Aviso");
            }
        }
    }
}

using AdminLabrary.conexion;
using AdminLabrary.modelos;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';

        }

        
        public void btnIniciarsesion_Click(object sender, EventArgs e)   
        {
            LinqL.Usuario = txtUsuario.Text;
            LinqL.Contra = txtContraseña.Text;
            LinqL.login();
            if (LinqL.inicio ==1)
            {
                MessageBox.Show("El Usuario o la Contraseña es Incorrecta");
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
                this.Hide();
            }
           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

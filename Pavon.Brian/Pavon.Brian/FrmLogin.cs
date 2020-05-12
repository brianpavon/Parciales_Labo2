using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavon.Brian
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == lblNombreUsuario.Text && txtContraseña.Text == lblPassword.Text)
            {
                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
                if(!(frmPrincipal.DialogResult == DialogResult.OK))
                {
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Datos invalidos", MessageBoxButtons.OK);
                txtUsuario.Text = String.Empty;
                txtContraseña.Text = String.Empty;
            }
        }
    }
}

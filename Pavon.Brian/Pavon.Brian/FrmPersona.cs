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
    public partial class FrmPersona : Form
    {
        int dni;
        
        public FrmPersona()
        {
            InitializeComponent();
            
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sexo"></param>
        /// <returns></returns>
        public bool ValidarSexo(string sexo)
        {
            if(sexo == "Femenino")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
               || !(int.TryParse(txtDni.Text, out dni)) || string.IsNullOrEmpty(cmbSexo.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void MensajeError()
        {
            MessageBox.Show("Debe cargar todos los campos", "Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public void ModificarFondo(Color color)
        {
            this.BackColor = color;
        }

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    this.nombre = txtNombre.Text;
        //    this.apellido = txtApellido.Text;
        //    this.dni = int.Parse(txtDni.Text);
        //    this.sexo = cmbSexo.Text;

        //}
        //public bool ValidarSexo()
        //{
        //    if (this.sexo == "Femenino")
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

    }
}

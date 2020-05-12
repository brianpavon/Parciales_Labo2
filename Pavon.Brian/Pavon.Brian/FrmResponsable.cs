using Entidades;
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
    public partial class FrmResponsable : FrmPersona
    {
        //string nombre;
        //string apellido;
        //int dni;
        //bool sexo;
        //string telefono;
        //EParentezco parentezco;
        Responsable responsable;
        public FrmResponsable()
        {
            InitializeComponent();
            base.ModificarFondo(Color.Blue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) 
            //   || !(int.TryParse(txtDni.Text,out dni)) || string.IsNullOrEmpty(cmbSexo.Text) 
            //   || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(cmbParentezco.Text))
               if(!(base.ValidarDatos()) || string.IsNullOrEmpty(txtTelefono.Text) 
                    || string.IsNullOrEmpty(cmbParentezco.Text))
            {
                //MessageBox.Show("Debe cargar todos los campos", "Error en la carga", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                base.MensajeError();
            }
            else
            {
                //this.nombre = txtNombre.Text;
                //this.apellido = txtApellido.Text;        
                //this.telefono = txtTelefono.Text;
                responsable = new Responsable(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                                               base.ValidarSexo(cmbSexo.Text),
                                               DevolverParentesco(cmbParentezco.Text), txtTelefono.Text);
                
                //FrmAlumno frmAlumno = new FrmAlumno();
                //frmAlumno.ShowDialog();
                
                this.DialogResult = DialogResult.OK;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Responsable DevolverResponsable
        {
            get 
            { 
                return this.responsable; 
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentezco"></param>
        /// <param name="strParentezco"></param>
        /// <returns></returns>
        private EParentezco DevolverParentesco(string strParentezco)
        {
            EParentezco parentesco = EParentezco.Otro;
            switch(strParentezco)
            {
                case "Madre":
                    parentesco = EParentezco.Madre;
                    break;
                case "Padre":
                    parentesco = EParentezco.Padre;
                    break;
                case "Tia":
                    parentesco = EParentezco.Tia;
                    break;
                case "Tio":
                    parentesco = EParentezco.Tio;
                    break;
                case "Abuela":
                    parentesco = EParentezco.Abuela;
                    break;
                case "Abuelo":
                    parentesco = EParentezco.Abuelo;
                    break;
                case "Otro":
                    parentesco = EParentezco.Otro;
                    break;
            }
            return parentesco;
        }
        

    }
}

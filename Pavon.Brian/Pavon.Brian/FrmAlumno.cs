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
    public partial class FrmAlumno : FrmPersona
    {
        Alumno alumno;
        int legajo;
        float valorCuota;
        //EColores colorSala;
        /// <summary>
        /// 
        /// </summary>
        public FrmAlumno()
        {
            InitializeComponent();
            base.ModificarFondo(Color.Pink);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!(base.ValidarDatos()) || string.IsNullOrEmpty(cmbSala.Text) || !(int.TryParse(txtDni.Text,out legajo))
                || !(float.TryParse(txtValorCuota.Text,out valorCuota)))
            {
                base.MensajeError();
            }
            else
            {
                alumno = new Alumno(txtNombre.Text, txtApellido.Text,int.Parse(txtDni.Text), 
                                    ValidarSexo(cmbSexo.Text), this.valorCuota);
                alumno.ColorSala = this.AsignarSala(cmbSala.Text);
                alumno.Legajo = int.Parse(txtLegajo.Text);

                //Abro el form para cargar el responsable y oculto el de alumnos
                FrmResponsable altaResponsable = new FrmResponsable();
                //this.Hide();
                altaResponsable.ShowDialog();
                if(altaResponsable.DialogResult == DialogResult.OK)
                {
                    alumno.Responsable = altaResponsable.DevolverResponsable;
                    this.DialogResult = DialogResult.OK;
                }
                else 
                {
                    this.DialogResult = DialogResult.Abort;
                }            

                
            }
        }

        public Alumno DevolverAlumno
        {
            get
            {
                return this.alumno;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strColor"></param>
        /// <returns></returns>
        private EColores AsignarSala(string strColor)
        {
            EColores colorSala = EColores.Verde;

            switch(strColor)
            {
                case "Naranja":
                    colorSala = EColores.Naranja;
                    break;
                case "Rojo":
                    colorSala = EColores.Rojo;
                    break;
                case "Amarillo":
                    colorSala = EColores.Amarillo;
                    break;
                case "Verde":
                    colorSala = EColores.Verde;
                    break;
            }
            return colorSala;
        }
    }
}

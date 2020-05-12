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
    public partial class FrmDocente : FrmPersonal
    {
        Docente docente;
        double valorHora;

        /// <summary>
        /// Constructor por defecto
        /// </summary>        
        public FrmDocente()
        {
            InitializeComponent();
            //this.HabilitarCargo = false;
            //this.SoloDocente = "Docente";
            //this.ModificarTitulo = "Bienvenido al Modulo de Alta del Personal Docente";
            //this.BackColor = Color.Aquamarine;
        }


        private void FrmDocente_Load(object sender, EventArgs e)
        {
            this.HabilitarCargo = false;
            this.SoloDocente = "Docente";
            this.ModificarTitulo = "Bienvenido al Modulo de Alta del Personal Docente";
            this.BackColor = Color.Aquamarine;
        }

        

        /// <summary>
        /// Toma todo lo cargado en el form, lo valida y si esta ok devuelve el docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!(base.ValidarDatos()) || string.IsNullOrEmpty(cmbHoraIngreso.Text) 
                || string.IsNullOrEmpty(cmbHoraSalida.Text) || !(double.TryParse(txtValorHora.Text,out valorHora)))
            {
                base.MensajeError();
            }
            else if(!(cmbHoraIngreso.Text == "08:00" || cmbHoraIngreso.Text == "13:00" 
                    || cmbHoraSalida.Text == "12:00" || cmbHoraSalida.Text == "17:00"))
            {
                MessageBox.Show("El docente solo ingresa a las 8 o 12 \n y se retira a las 13 o 17",
                                "Error en la hora", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                docente = new Docente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), base.ValidarSexo(cmbSexo.Text),
                                      DateTime.Parse(cmbHoraIngreso.Text),DateTime.Parse(cmbHoraSalida.Text), 
                                      double.Parse(txtValorHora.Text));

                this.DialogResult = DialogResult.OK;
            }
        }

        #region Propiedades
        /// <summary>
        /// Devuelve un docente
        /// </summary>
        public Docente DevolverDocente
        {
            get
            {
                return this.docente;
            }
        }
        #endregion
    }
}

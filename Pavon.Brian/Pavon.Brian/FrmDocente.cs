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
        /// 
        /// </summary>        
        public FrmDocente()
        {
            InitializeComponent();
            this.HabilitarCargo = false;
            this.SoloDocente = "Docente";
            this.ModificarTitulo = "Bienvenido al Modulo de Alta del Personal Docente";
            this.BackColor = Color.Aquamarine;
        }


        /// <summary>
        /// 
        /// </summary>
        public Docente DevolverDocente
        {
            get
            {
                return this.docente;
            }
        }

        /// <summary>
        /// 
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
            else
            {
                docente = new Docente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), base.ValidarSexo(cmbSexo.Text),
                                      DateTime.Parse(cmbHoraIngreso.Text),DateTime.Parse(cmbHoraSalida.Text), 
                                      double.Parse(txtValorHora.Text));

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

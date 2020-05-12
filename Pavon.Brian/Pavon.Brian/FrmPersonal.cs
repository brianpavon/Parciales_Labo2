using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Pavon.Brian
{
    public partial class FrmPersonal : FrmPersona
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        #region Propiedades

        /// <summary>
        /// Propiedad que en case de necesitar habilita el combo box con los puestos
        /// </summary>
        public bool HabilitarCargo
        {
            set
            {
                this.cmbCargo.Enabled = value;
            }
        }

        /// <summary>
        /// Carga en el cmbCargo lo que necesite
        /// </summary>
        public string SoloDocente
        {
            set
            {
                this.cmbCargo.Text = value;
            }
        }

        /// <summary>
        /// En caso de ser no docente no necesita el campo valor por horas por lo tanto puedo no mostrarlo
        /// </summary>
        public bool HabilitarHoras
        {
            set
            {
                this.lblValorHora.Visible = value;
                this.txtValorHora.Visible = value;
            }
        }

        /// <summary>
        /// Modifica el titulo de acuerdo a quien use el form
        /// </summary>
        public string ModificarTitulo
        {
            set
            {
                this.lblTitulo.Text = value;
            }
        }

        #endregion


    }
}

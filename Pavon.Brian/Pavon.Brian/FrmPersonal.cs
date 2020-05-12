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

        /// <summary>
        /// 
        /// </summary>
        public bool HabilitarCargo
        {
            set
            {
                this.cmbCargo.Enabled = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SoloDocente
        {
            set
            {
                this.cmbCargo.Text = value;
            }
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public string ModificarTitulo
        {
            set
            {
                this.lblTitulo.Text = value;
            }
        }       

       
        
    }
}

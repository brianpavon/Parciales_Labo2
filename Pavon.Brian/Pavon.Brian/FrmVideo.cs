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
    public partial class FrmVideo : Form
    {
        public FrmVideo()
        {
            InitializeComponent();
        }


        /// <summary>
        /// carga el video de baby shark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaby_Click(object sender, EventArgs e)
        {
            this.wmpVideos.URL = "https://examenprog.000webhostapp.com/Tiburoncito.mp4";
        }

        /// <summary>
        /// Carga el video de pepa pig
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSilbidos_Click(object sender, EventArgs e)
        {
            this.wmpVideos.URL = "https://examenprog.000webhostapp.com/Silbar.mp4";
        }

        /// <summary>
        /// carga el video de los bloopers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlooper_Click(object sender, EventArgs e)
        {
            this.wmpVideos.URL = "https://examenprog.000webhostapp.com/BloopersTS2.mp4";
        }

        /// <summary>
        /// Pone stop al video y sale del form devolviendo un ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.wmpVideos.Ctlcontrols.stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

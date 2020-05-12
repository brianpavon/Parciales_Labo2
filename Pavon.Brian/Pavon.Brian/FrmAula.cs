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
    public partial class FrmAula : Form
    {
        List<Docente> listaDocentes;
        List<Alumno> listaAlumnos;
        Aula aula;

        EColores colorSala;
        public FrmAula()
        {
            InitializeComponent();
            listaDocentes = FrmPrincipal.ListaDocentes;
            listaAlumnos = FrmPrincipal.ListaAlumnos;
            this.HabilitarListas = false;           
            
        }       
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            if(lbDocentes.SelectedIndex == -1)
            {
                MessageBox.Show("Necesita elegir opciones", "Error!!", MessageBoxButtons.OK);
            }
            else
            {
                int index;
                int indexAlumnos;
                index = lbDocentes.SelectedIndex;
                indexAlumnos = lbAlumnosSinSala.SelectedIndex;

                aula = new Aula(this.colorSala,PasarTurno(cmbTurno.Text),listaDocentes[index]);
                aula.Alumnos = listaAlumnos;
                this.DialogResult = DialogResult.OK;
            }

        }        

              
        private void btnCargar_Click(object sender, EventArgs e)
        {

            this.HabilitarListas = true;
            lbDocentes.Items.Clear();
            lbAlumnosSinSala.Items.Clear();
            CargarListaDocentes();
            CargarListaAlumnos();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        //METODOS:

        /// <summary>
        /// Cambia el color de fondo del formulario de acuerdo a lo que necesite
        /// </summary>
        /// <param name="color"></param>
        public void CambiarFondo(Color color)
        {
            this.BackColor = color;
        }
        
        public bool HabilitarListas
        {
            set
            {
                this.lbAlumnosAsignados.Visible = value;
                this.lbAlumnosSinSala.Visible = value;
                this.lbDocentes.Visible = value;
                this.btnAsignar.Visible = value;
            }
        }

        private void CargarListaDocentes()
        {

            foreach (Docente docente in listaDocentes)
            {

                if (cmbTurno.Text == "Mañana" && docente.HoraEntrada.Hour == 08)
                {
                    //lbDocentes.Items.Add(MostrarDatosDocente(docente));
                    lbDocentes.Items.Add(MostrarDatos(docente));
                }
            }

            foreach (Docente docente in listaDocentes)
            {
                if (cmbTurno.Text == "Tarde" && docente.HoraEntrada.Hour == 13)
                {
                    //lbDocentes.Items.Add(MostrarDatosDocente(docente));
                    lbDocentes.Items.Add(MostrarDatos(docente));
                }
            }

        }
       

        public ETurno PasarTurno(string turno)
        {
            ETurno aux = 0;
            switch(turno)
            {
                case "Mañana":
                    aux = ETurno.Mañana;
                    break;
                case "Tarde":
                    aux = ETurno.Tarde;
                    break;
            }
            return aux;
        }
        public EColores Color
        {
            set
            {
                this.colorSala = value;
            }
            get
            {
                return this.colorSala;
            }
        }        

        public string MostrarDatos(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(persona.Nombre);
            sb.Append(" ");
            sb.Append(persona.Apellido);
            return sb.ToString();
        }

        private void CargarListaAlumnos()
        {
            
            foreach (Alumno alumno in listaAlumnos)
            {
                
                if (alumno.ColorSala == this.colorSala)
                {
                    lbAlumnosSinSala.Items.Add(MostrarDatos(alumno));
                }
            }          

        }

        
    }
}

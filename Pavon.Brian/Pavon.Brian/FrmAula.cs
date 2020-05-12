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
        List<Alumno> listaAlumnosEnAula;
        List<Alumno> listaAlumnosSinSala;
        List<Aula> listaAulas;
        Aula aula;

        /// <summary>
        /// Declaro este enumerado para poder hacer comparaciones con los turnos y aulas
        /// </summary>
        EColores colorSala;
        public FrmAula()
        {
            InitializeComponent();
            //no habia utilizado getters y setters
            //listaDocentes = FrmPrincipal.ListaDocentes;
            //listaAlumnos = FrmPrincipal.ListaAlumnos;
            
            //this.HabilitarListas = false;           
            
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            this.HabilitarListas = false;
            listaAlumnosEnAula = new List<Alumno>();
            listaAlumnosSinSala = new List<Alumno>();

            //NO SE PORQUE INSTANCIE ESTAS LISTAS 
            //listaAlumnos = new List<Alumno>();
            //listaDocentes = new List<Docente>();
            //listaAulas = new List<Aula>();
        }


        /// <summary>
        /// Crea una sala solo si tiene un docente seleccionado
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
                //int indexAlumnos;
                index = lbDocentes.SelectedIndex;
                //indexAlumnos = lbAlumnosSinSala.SelectedIndex;

                aula = new Aula(this.colorSala,PasarTurno(cmbTurno.Text),listaDocentes[index]);
                //aula.Alumnos = listaAlumnosEnAula;
                foreach (Alumno alumno in listaAlumnosEnAula)
                {
                    if (!(aula + alumno))
                        this.DialogResult = DialogResult.Abort;
                }
                this.DialogResult = DialogResult.OK;
            }

        }        

         
        /// <summary>
        /// Carga las listas de acuerdo al turno elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {

            this.HabilitarListas = true;
            lbDocentes.Items.Clear();
            lbAlumnosSinSala.Items.Clear();
            CargarListaDocentes();
            CargarListaAlumnos();
            //SepararAlumnos();
            
        }

        /// <summary>
        /// Cierra el form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        /// <summary>
        /// Asigna alumnos que no esten en ninguna sala a alguna sala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int index;
            index = lbAlumnosSinSala.SelectedIndex;

            //saco del list box sin sala y lo cargo en la lista de la clase
            lbAlumnosAsignados.Items.Add(lbAlumnosSinSala.SelectedItem);
            lbAlumnosSinSala.Items.Remove(lbAlumnosSinSala.SelectedItem);

            //agrego en list box asignados y lo saco de la lista de la clase
            listaAlumnosEnAula.Add(listaAlumnosSinSala[index]);
            listaAlumnosSinSala.RemoveAt(index);

        }

        #region Metodos
        //METODOS:

        /// <summary>
        /// Cambia el color de fondo del formulario de acuerdo a lo que necesite
        /// </summary>
        /// <param name="color"></param>
        public void CambiarFondo(Color color)
        {
            this.BackColor = color;
        }

        /// <summary>
        /// Carga la lista de los docentes
        /// </summary>
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

        /// <summary>
        /// Muestra solo nombre y apellido, para usar en loslist box
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public string MostrarDatos(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(persona.Nombre);
            sb.Append(" ");
            sb.Append(persona.Apellido);
            return sb.ToString();
        }


        /// <summary>
        /// Nos devuelve un turno de acuerdo a lo que se selecciona en el cmbBox
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        public ETurno PasarTurno(string turno)
        {
            ETurno aux = 0;
            switch (turno)
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

        /// <summary>
        /// Carga la lista de alumnos sin asignar
        /// </summary>
        private void CargarListaAlumnos()
        {

            foreach (Alumno alumno in listaAlumnos)
            {

                if (alumno.ColorSala == this.colorSala)
                {
                    lbAlumnosSinSala.Items.Add(MostrarDatos(alumno));
                    listaAlumnosSinSala.Add(alumno);
                }
            }

        }

        //ME DI CUENTA QUE LO PODIA HACER DIRECTAMENTE EN CARGAR LISTA ALUMNOS
        //private void SepararAlumnos()
        //{
        //    foreach (Alumno alumno in listaAlumnos)
        //    {
        //        if(alumno.ColorSala == this.colorSala)
        //        {
        //            listaAlumnosSinSala.Add(alumno);
        //        }

        //    }
        //}

        #endregion


        #region Propiedades
        /// <summary>
        /// Habilita las listas una vez seleccionado el turno
        /// </summary>
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

        /// <summary>
        /// Devuelve o Setea el color de sala
        /// </summary>
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

        /// <summary>
        /// Retorna el aula
        /// </summary>
        public Aula DevolverAula
        {
            get
            {
                return this.aula;
            }
        }

        /// <summary>
        /// Setea o retorna una lista de Alumnos
        /// </summary>
        public List<Alumno> ListaAlumnos
        {
            get
            {
                return this.listaAlumnos;
            }
            set
            {
                this.listaAlumnos = value;
            }
        }

        /// <summary>
        /// Setea o devuelve una lista de alumnos que aun no tienen aula
        /// </summary>
        public List<Alumno> ListaAlumnosSinAula
        {
            get
            {
                return this.listaAlumnosSinSala;
            }
            set
            {
                this.listaAlumnosSinSala = value;
            }
        }

        /// <summary>
        /// Setea o Devuelve una lista con alumnos con aula
        /// </summary>
        public List<Alumno> ListaAlumnosEnAula
        {
            get
            {
                return this.listaAlumnosEnAula;
            }
            set
            {
                this.listaAlumnosEnAula = value;
            }
        }

        /// <summary>
        /// Setea o devuelve una lista de Docentes
        /// </summary>
        public List<Docente> ListaDocentes
        {
            get
            {
                return this.listaDocentes;
            }
            set
            {
                this.listaDocentes = value;
            }
        }
        #endregion





    }
}

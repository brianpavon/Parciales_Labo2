using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavon.Brian
{
    public partial class FrmReportes : Form
    {
        List<Docente> listaDocentes;
        List<Alumno> listaAlumnos;
        List<Administrativo> listaNoDocentes;
        List<Aula> listaAulas;
        public FrmReportes()
        {
            InitializeComponent();
            
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            cmbColorSala.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            //listaAlumnos = new List<Alumno>();
            //listaDocentes = new List<Docente>();
            //listaNoDocentes = new List<Administrativo>();
            //listaAulas = new List<Aula>();
        }

        /// <summary>
        /// Cierra el form retornando un OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vuelve al Menu Principal", "Saliendo del reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// De acuerdo al turno y sala elegida muestra los datos de los padres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rchReporte.Clear();
            CargarPadres();
        }

        /// <summary>
        /// Devuelve la recaudacion total del jardin, cargandola en el RichTextBox
        /// </summary>
        public void RecaudacionTotal()
        {
            float recaudacionTotal = 0;
            float recaudacionPorSala = 0;
            foreach (Aula auxAula in listaAulas)
            {
                foreach (Alumno auxAlumno in auxAula.Alumnos)
                {
                    
                    recaudacionPorSala += auxAlumno.PrecioCuota;                   
                }
                recaudacionTotal += recaudacionPorSala;
                //rchReporte.AppendText("El total de Dinero del Jardin es: \n" + recaudacionTotal.ToString() + "\n" + "\n");
            }
            rchReporte.AppendText("El total de Dinero del Jardin es: \n" + recaudacionTotal.ToString() + "\n" + "\n");
        }

        /// <summary>
        /// Carga en el rich text box la recaudacion por sala
        /// </summary>
        public void RecaudacionPorSala()
        {
            float recaudacion = 0;
            foreach (Aula auxAula in listaAulas)
            {

                foreach (Alumno auxAlumno in auxAula.Alumnos)
                {
                    if(auxAlumno.ColorSala == auxAula.ColorSala)
                    {
                        recaudacion += auxAlumno.PrecioCuota;
                    }
                    rchReporte.AppendText(auxAula.ColorSala.ToString() + "\n");
                    rchReporte.AppendText(auxAula.Turno.ToString() + "\n");
                    rchReporte.AppendText("$" + recaudacion.ToString() + "\n" + "\n");
                }
            }
           
        }

        /// <summary>
        /// Metodo para mostrar sueldo de docente
        /// </summary>
        public void MostrarSueldoDocente()
        {
            rchReporte.Clear();
            foreach (Docente docente in listaDocentes)
            {
                //rchReporte.Clear();
                rchReporte.AppendText("Nombre: "+ docente.Nombre + "\n");
                rchReporte.AppendText("Apellido: "+ docente.Apellido + "\n");
                rchReporte.AppendText("$"+docente.CalcularSalario().ToString() + "\n" + "\n");
            }            
        }

        //Todavia no se me ocurrio como reutilizar el codigo
        /// <summary>
        /// Todavia no se me ocurrio como reutilizar el codigo devuelve el sueldo del no docente
        /// </summary>
        public void MostrarSueldoNoDocente()
        {
            rchReporte.Clear();
            foreach (Administrativo noDocente in listaNoDocentes)
            {
                //rchReporte.Clear();
                rchReporte.AppendText("Nombre: "+noDocente.Nombre + "\n");
                rchReporte.AppendText("Apellido: "+noDocente.Apellido + "\n");
                rchReporte.AppendText("Cargo: " + noDocente.Cargo.ToString() + "\n");
                rchReporte.AppendText("$" + noDocente.CalcularSalario().ToString() + "\n" + "\n");
            }
        }


        

        #region Metodos:
        /// <summary>
        /// Devuelve los datos de los padres de las aulas
        /// </summary>
        public void CargarPadres()
        {
            //rchReporte.Enabled = false;
            
            foreach (Aula aux in listaAulas)
            {  
                if(aux.ColorSala.ToString() == this.cmbColorSala.Text 
                    && aux.Turno.ToString() == this.cmbTurno.Text)
                {
                    foreach (Alumno alumno in aux.Alumnos)
                    {
                        //Responsable responsable = new Responsable();
                        if (alumno.ColorSala == aux.ColorSala)
                        {
                            //retorno = item.Responsable.Telefono;
                            
                            rchReporte.AppendText("Nombre: " + alumno.Responsable.Nombre + "\n");
                            rchReporte.AppendText("Apellido: " + alumno.Responsable.Apellido + "\n");
                            rchReporte.AppendText("Telefono: " + alumno.Responsable.Telefono + "\n" + "\n");
                        }

                    }

                }
                
            }
            //string retorno = String.Empty;
            
            //return retorno;
        }

        //Pude solucionarlo en un solo metodo
        //public void MostrarPadres()
        //{
        //    //foreach (Alumno alumno  in collection)
        //    //{

        //    //}
        //}

        #endregion  


        #region Propiedades

        /// <summary>
        /// Cambia el color del fondo del form
        /// </summary>
        /// <param name="color"></param>
        public void CambiarFondo(Color color)
        {
            this.BackColor = color;
        }

        /// <summary>
        /// Setea el titulo del Form
        /// </summary>
        public string SetearTituloForm 
        {
            set
            {                
                this.Text = value;
            }
        }

        /// <summary>
        /// Setea el label con un mensaje
        /// </summary>
        public string SetearMensajeReporte
        {
            set
            {
                this.lblTitulo.Text = value; ;
            }
        }


        /// <summary>
        /// Habilita comandos que son utiles para el reporte de los padres
        /// </summary>
        public bool HabilitarParaPadres
        {
            set
            {
                this.cmbColorSala.Visible = value;
                this.cmbTurno.Visible = value;
                this.lblElija.Visible = value;
                this.btnMostrar.Visible = value;
            }

        }

        //quise probar de hacerle columnas al richtextbox
        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    ListViewItem listaReportes = new ListViewItem("Recaudacion");
        //    listaReportes.SubItems.Add("PEPE");
        //}

        /// <summary>
        /// Devuelve o setea una lista de aulas
        /// </summary>
        public List<Aula> ListaAulas
        {
            get
            {
                return this.listaAulas;
            }
            set
            {
                this.listaAulas = value;
            }
        }

        /// <summary>
        /// Devuelve o setea una lista de alumnos
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
        /// Devuelve o setea una lista de docentes
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

        /// <summary>
        /// Devuelve o setea una lista con el personal no docente
        /// </summary>
        public List<Administrativo> ListaNoDocente
        {
            get
            {
                return this.listaNoDocentes;
            }
            set
            {
                this.listaNoDocentes = value;
            }
        }


        #endregion

        
    }
}

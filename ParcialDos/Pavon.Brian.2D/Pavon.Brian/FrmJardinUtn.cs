using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace Pavon.Brian
{
    public partial class FrmJardinUtn : Form
    {

        #region Atributos
        int conteo = 0;
        FrmProximoLlamado proximo;
        //List<Thread> hilosJardin;
        List<Docente> docentes;
        //List<Aula> aulas;
        //List<Alumno> alumnos;
        Queue<Alumno> alumnos;
        Thread hiloRecreo;
        #endregion

        #region Delegados
        public delegate void RecreoClases();
        #endregion

        Serializacion<List<Docente>> cargarDocentes = new Serializacion<List<Docente>>();
        #region Eventos

        public event RecreoClases CambiarLabel;
        #endregion
        

        
        

        /// <summary>
        /// Contructor que incia el formulario principal
        /// </summary>
        public FrmJardinUtn()
        {
            InitializeComponent();
            this.CargarDatos();
            //hilosJardin = new List<Thread>();
            hiloRecreo = new Thread(DeNuevoAlAula);
            //hilosJardin.Add(hiloRecreo);
            CambiarLabel += MandarAlRecreo;
        }

        /// <summary>
        /// Evento por el que se abriran los otros 2 formularios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                btnIniciar.Click -= btnIniciar_Click;
                IniciarProcesos();
                //if (tmrTotalEvaluacion.Enabled == false)
                //{
                //    tmrTotalEvaluacion.Start();
                //}
                //if (!hiloRecreo.IsAlive)
                //{
                //    hiloRecreo.Start();
                //}
                proximo = new FrmProximoLlamado();
                proximo.Alumnos = this.Alumnos;
                proximo.Docentes = this.Docentes;
                proximo.EliminarProcesos += this.CerrarProcesos;
                proximo.Show();
            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            

        }


        /// <summary>
        /// Evento que cerrara hilos y terminara con el timer y cerrara los otros form si fueron instanciados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JardinUtn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!(proximo is null))
            {
                proximo.Close();
            }
            CerrarProcesos();
            //if (!hiloRecreo.IsAlive)
            //{
            //    hiloRecreo.Abort();
            //}
        }

        /// <summary>
        /// Establece el conteo del timer y setea un mensaje de cuantos segundos van desde que se inicio a evaluar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTotalEvaluacion_Tick(object sender, EventArgs e)
        {
            conteo++;
            this.lblCronometro.Text = string.Format("Van {0} segundos desde que se inicio a evaluar", conteo.ToString());

        }

        #region Propiedades

        /// <summary>
        /// Propiedad que setea o devuelve la cola de alumnos
        /// </summary>
        public Queue<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Propiedad que setea o devuelve la lista de docentes
        /// </summary>        
        public List<Docente> Docentes
        {
            get 
            { 
                return this.docentes; 
            }
            set 
            {
                this.docentes = value; 
            }
        }

        /// <summary>
        /// Propiedad que setea o devuelve la lista de alumnos
        /// </summary>        
        //public List<Alumno> Alumnos
        //{
        //    get
        //    {
        //        return this.alumnos;
        //    }
        //    set
        //    {
        //        this.alumnos = value;
        //    }
        //}


        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que inicia los procesos, las conexiones e  instancia las listas o colas
        /// </summary>
        private void CargarDatos()
        {

            //rchDocentes.ReadOnly = true;
            //DataGridAlumnos.ReadOnly = true;
            //DataGridAlumnos.RowHeadersVisible = false;
            //DataGridAlumnos.ColumnHeadersVisible = false;
            //DataGridAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //DataGridAlumnos.AllowUserToAddRows = false;
            try
            {
                docentes = new List<Docente>();
                //alumnos = new List<Alumno>();
                alumnos = new Queue<Alumno>();
                //aulas = new List<Aula>();
                this.DataGridAlumnos.DataSource = ManejadorSQL.RealizarConsulta("select * from alumnos");
                //alumnos = ManejadorSQL.ObtenerDatos("select * from alumnos");
                alumnos = ManejadorSQL.ObtenerDatosAlumno("select * from alumnos");
                cargarDocentes.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml", out docentes);
                foreach (Docente item in docentes)
                {
                    rchDocentes.AppendText(item.MostrarDatos() + "\n");
                    ManejadorSQL.InsertarDocente(item);
                }
                
            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            
            
        }

        /// <summary>
        /// Metodo que inicia los hilos y procesos
        /// </summary>
        private void IniciarProcesos()
        {

            if (tmrTotalEvaluacion.Enabled == false)
            {
                tmrTotalEvaluacion.Start();
            }
            //foreach (Thread hilo in hilosJardin)
            //{
            if (!hiloRecreo.IsAlive)
            {
                hiloRecreo.Start();
            }
            //}
        }


        /// <summary>
        /// Metodo que cierra y termina con el timer e hilos
        /// </summary>
        private void CerrarProcesos()
        {

            //foreach (Thread hilo in hilosJardin)
            //{
            if (hiloRecreo.IsAlive)
            {
                hiloRecreo.Abort();
            }
            //}
            if (tmrTotalEvaluacion.Enabled == true)
            {
                tmrTotalEvaluacion.Stop();
                lblAvisoRecreo.Text = string.Format("La evaluacion llevo {0} segundos", this.conteo.ToString());
                lblCronometro.Enabled = false;
            }

        }

        /// <summary>
        /// Metodo que realiza el cambio en label avisando del recreo, ademas muestra un message box, y llama el metodo de nuevo al aula
        /// </summary>
        private void MandarAlRecreo()
        {
            //if (lblAvisoRecreo.InvokeRequired)
            //{
            //    lblAvisoRecreo.BeginInvoke((MethodInvoker)delegate ()
            //    {
            //        lblAvisoRecreo.Text = "Es Hora del Recreo... A divertirse!!!";
            //    });
            //}
            //else
            //{
            //    lblAvisoRecreo.Text = "Es Hora del Recreo... A divertirse!!!";
            //}
            CambiarMensajes(this.lblAvisoRecreo, "Es Horal del Recreo... A Divertirse");
            MessageBox.Show("ES HORA DE RECREO", "Recreo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(5000);
            //MessageBox.Show("DE VUELTA AL AULA", "Llamado a clases", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            DeNuevoAlAula();
        }

        /// <summary>
        /// Metodo que notifica que hay que volver al aula, e invoca al evento CambiaLabel, quien es usado por Mandar al recreo
        /// </summary>
        private void DeNuevoAlAula()
        {
            //if (lblAvisoRecreo.InvokeRequired)
            //{
            //    lblAvisoRecreo.BeginInvoke((MethodInvoker)delegate ()
            //    {
            //        lblAvisoRecreo.Text = "Hora de Clases";
            //    });
            //}
            //else
            //{
            //    lblAvisoRecreo.Text = "Hora de Clases";
            //}
            CambiarMensajes(this.lblAvisoRecreo, "Hora de Clases");
            Thread.Sleep(20000);
            CambiarLabel.Invoke();
        }

        /// <summary>
        /// Metodo que realiza los cambios en los labels
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="mensaje"></param>
        private void CambiarMensajes(object obj, string mensaje)
        {
            Label auxLabel = (Label)obj;
            if (auxLabel.InvokeRequired)
            {
                auxLabel.BeginInvoke((MethodInvoker)delegate ()
                {
                    auxLabel.Text = mensaje;
                });
            }
            else
            {
                auxLabel.Text = mensaje;
            }
        }

        #endregion


        #region Codigo Feo

        //foreach (Docente docente in docentes)
        //{
        //    ManejadorSQL.InsertarDocentes("insert into Docentes (Nombre,Apellido,Edad,Sexo,Dni,Direccion,Email) values", Docente.DevolverLosParametros(docente));
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        //private void MostrarTiempo(object obj)
        //{
        //    Label lblModificado = (Label)obj;

        //    while (true)
        //    {
        //       if (lblModificado.InvokeRequired)
        //       {
        //             lblModificado.BeginInvoke((MethodInvoker)delegate ()
        //             {
        //              lblModificado.Text = DateTime.Now.Hour.ToString();
        //             });
        //       }
        //        else
        //        {
        //             lblModificado.Text = DateTime.Now.Hour.ToString();
        //        }
        //        Thread.Sleep(1000);

        //    }
        //}

        #endregion


    }
}

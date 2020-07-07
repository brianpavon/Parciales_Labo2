using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Pavon.Brian
{
    public partial class FrmProximoLlamado : FrmEvaluacion
    {
        #region Delegados
        public delegate void MostrarProximos();
        public delegate void ActualizarLista();
        public delegate void TerminarProcesos();
        public delegate void LanzarDatos(Alumno alumno, Docente docente);

        #endregion

        #region Atributos
        private Queue<Alumno> colaAlumnos;
        //private List<Alumno> alumnos;
        private List<Docente> docentes;

        Random indiceRandom = new Random();
        FrmEvaluacion evaluacion;
        Thread hiloProximo;

        #endregion


        #region Eventos
        public event MostrarProximos CargarProximos;
        public event LanzarDatos MandarAEvaluar;
        //public event LanzarDatos CargarEspera;

        public event ActualizarLista ActualizarRecreo;
        public event TerminarProcesos EliminarProcesos;//lo llamo desde el primer form

        #endregion


        #region Propiedades
        /// <summary>
        /// 
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
        /// 
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



        /// <summary>
        /// 
        /// </summary>  
        public Queue<Alumno> Alumnos
        {
            get
            {
                return this.colaAlumnos;
            }
            set
            {
                this.colaAlumnos = value;
            }
        }
        #endregion


        /// <summary>
        /// Constructor del Formulario, se pasan manejadores y se incian hilos
        /// </summary>
        public FrmProximoLlamado()
        {
            try
            {
                InitializeComponent();
                evaluacion = new FrmEvaluacion();

                //this.MandarAEvaluar += evaluacion.MostrarEnPantalla;
                //evaluacion.MostrarExamen += this.MandarAEvaluar;

                evaluacion.Show();

                CargarProximos += ProximoEnEvaluar;
                //CargarEspera += MostrarProximo;
                ActualizarRecreo += evaluacion.ActualizarListaRecreo;
                MandarAEvaluar += evaluacion.MostrarEnPantalla;

                hiloProximo = new Thread(ProximoEnEvaluar);
                if (!hiloProximo.IsAlive)
                {
                    hiloProximo.Start();
                }
            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            
        }
        /// <summary>
        /// Metodo que invoca a eliminarprocesos, para terminar con hilos del formulario, cierra el form evaluaciony termina con su hilo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProximoLlamado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hiloProximo.IsAlive)
            {
                 hiloProximo.Abort();
            }
            evaluacion.Close();
            EliminarProcesos.Invoke();
        }

        #region Metodos

        /// <summary>
        /// Metodo que carga en el text box y en el ricth textbox los datos del docente y alumno
        /// </summary>
        /// <param name="alumno">Objeto alumno que se cargara en el richtextbox</param>
        /// <param name="docente">Objeto docente que se cargara en el textbox</param>
        private void CargarCampos(Alumno alumno,Docente docente)
        {
            if (txtDocente.InvokeRequired)
            {
                txtDocente.BeginInvoke((MethodInvoker)delegate ()
                {
                    txtDocente.Text = string.Format("{0} {1}", docente.Nombre.ToString(), docente.Apellido.ToString());
                });
            }
            else
            {
                txtDocente.Text = string.Format("{0} {1}", docente.Nombre.ToString(), docente.Apellido.ToString());
            }
            if (rchDatosAlumno.InvokeRequired)
            {
                rchDatosAlumno.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.rchDatosAlumno.Text = alumno.MostrarDatos();
                });
            }
            else
            {
                this.rchDatosAlumno.Text = alumno.MostrarDatos();
            }
            
        }

        /// <summary>
        /// Usa un random para asignar docentes a evaluar, y llama al metodo mostrar proximo quien muestra los alumnos y docentes en el formulario
        /// </summary>
        private void ProximoEnEvaluar()
        {
            if (colaAlumnos.Count > 0)
            {
                int indexDocente = indiceRandom.Next(0, docentes.Count - 1);
                //int indexAlumno = indiceRandom.Next(0, alumnos.Count-1);
                //CargarCampos(alumnos.Dequeue(), docentes.ElementAt(index));
                MostrarProximo(colaAlumnos.Dequeue(), docentes.ElementAt(indexDocente));

                //MostrarProximo(alumnos.ElementAt(indexAlumno), docentes.ElementAt(indexDocente));
                //alumnos.RemoveAt(indexAlumno);
            }
            else
            {
                MessageBox.Show("Se evaluaron a todos los alumnos");

            }
           
        }

        /// <summary>
        /// Metodo que inicia el evento, y va cargando nuevos docentes y alumnos cada 8 segundos, invoca a los eventos que cargan en el 3 formulario
        /// </summary>
        /// <param name="alumno">Alumno que se mostrara como proximo</param>
        /// <param name="docente">Docente que se mostrara como proximo</param>
        private void MostrarProximo(Alumno alumno,Docente docente)
        {
            //int nota1 = indiceRandom.Next(0, 10);
            //int nota2 = indiceRandom.Next(0, 10);
            //float notaFinal = (nota1 + nota2) / 2;
            //ACA ARRANCABA EL POSTA
            CargarCampos(alumno, docente);//carga el docente
            ActualizarRecreo.Invoke();//evento que llama al metodo que muestra en la lista de recreo del 3 form
            Thread.Sleep(8000);//pausa de 8 segundos para evaluar y que espera el siguiente

            MandarAEvaluar.Invoke(alumno, docente);//se pasa el alumno a evaluar al 3 form
            CargarProximos.Invoke();//invoca al metodo que continua con el hilo de mostrar y pasar
        }




        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="alumno"></param>
        ///// <param name="docente"></param>
        //private void PasarDatos(Alumno alumno, Docente docente)
        //{

        //    MandarAEvaluar.Invoke(alumno, docente);
        //}

        #endregion

        

       
    }
}

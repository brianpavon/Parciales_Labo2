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
        public delegate void MostrarProximos();
        public delegate void ActualizarLista();
        public delegate void TerminarProcesos();
        public delegate void LanzarDatos(Alumno alumno, Docente docente);

        private Queue<Alumno> colaAlumnos;
        //private List<Alumno> alumnos;
        private List<Docente> docentes;
        
        Random indiceRandom = new Random();

        public event MostrarProximos CargarProximos;
        public event LanzarDatos MandarAEvaluar;
        //public event LanzarDatos CargarEspera;

        public event ActualizarLista ActualizarRecreo;
        public event TerminarProcesos EliminarProcesos;//lo llamo desde el primer form

        FrmEvaluacion evaluacion;
        Thread hiloProximo;

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


        public FrmProximoLlamado()
        {
            try
            {
                InitializeComponent();
                this.rctAlumnosEnRecreo.Visible = false;
                this.lblAlRecreo.Visible = false;

                evaluacion = new FrmEvaluacion();

                //this.MandarAEvaluar += evaluacion.MostrarEnPantalla;
                //evaluacion.MostrarExamen += this.MandarAEvaluar;

                evaluacion.Show();

                CargarProximos += ProximoEnEvaluar;
                //CargarEspera += MostrarProximo;
                ActualizarRecreo += evaluacion.ActualizarListaRecreo;
                MandarAEvaluar += evaluacion.MostrarEnPantalla;

                hiloProximo = new Thread(ProximoEnEvaluar);
                hiloProximo.Start();
            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProximoLlamado_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiloProximo.Abort();
            evaluacion.Close();
            EliminarProcesos.Invoke();
        }

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="docente"></param>
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
        /// Utiliza 2 metodos para cargar los formularios
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
        /// 
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="docente"></param>
        private void MostrarProximo(Alumno alumno,Docente docente)
        {
            //int nota1 = indiceRandom.Next(0, 10);
            //int nota2 = indiceRandom.Next(0, 10);
            //float notaFinal = (nota1 + nota2) / 2;
            //ACA ARRANCABA EL POSTA
            CargarCampos(alumno, docente);
            ActualizarRecreo.Invoke();
            Thread.Sleep(1000);

            MandarAEvaluar.Invoke(alumno, docente);
            CargarProximos.Invoke();
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

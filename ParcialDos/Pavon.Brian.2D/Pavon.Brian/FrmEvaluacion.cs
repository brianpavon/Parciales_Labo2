using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Pavon.Brian
{
    public partial class FrmEvaluacion : Form
    {
        //public delegate void ReciboPersonas(Alumno alumno,Docente docente);
        //public event ReciboPersonas MostrarExamen;
        //public event LanzarDatos MostrarExamen;

        #region Atributos
        //Thread hiloEvaluacion;
        List<Alumno> alumnos;
        List<Aula> aulas;
        Random indexAula;
        //int flag = 0;

        #endregion


        /// <summary>
        /// Constructordel formulario, donde se instacian aulas y se conecta con la base de datos para cargar las aulas, mediante el metodo Cargar
        /// </summary>
        public FrmEvaluacion()
        {
            InitializeComponent();
            this.CargarDatos();
            alumnos = new List<Alumno>();
            indexAula = new Random();
            //hiloEvaluacion = new Thread(ActualizarListaRecreo);
            //hiloEvaluacion.Start();


            //hiloEvaluacion = new Thread(MostrarEnPantalla);
            //MostrarExamen += MostrarEnPantalla;
        }

        #region Metodos
        /// <summary>
        /// Metodo que instancia la lista de Aulas, y la carga desde la base de datos
        /// </summary>
        private void CargarDatos()
        {
            aulas = new List<Aula>();
            aulas = ManejadorSQL.CargarAulas("select * from Aulas");
        }

        /// <summary>
        /// Metodo que va mostrando el alumno que se esta evaluando y el docente que evalua
        /// </summary>
        /// <param name="alumno">Alumno evaluado</param>
        /// <param name="docente">Docente evaluador</param>
        public void MostrarEnPantalla(Alumno alumno, Docente docente)
        {
            try
            {
                int index = indexAula.Next(0, 6);
                if (rchDatosAlumno.InvokeRequired)
                {
                    rchDatosAlumno.BeginInvoke((MethodInvoker)delegate ()
                    {
                        rchDatosAlumno.Text = alumno.MostrarDatos();
                    });
                }
                else
                {
                    rchDatosAlumno.Text = alumno.MostrarDatos();
                }
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
                alumnos.Add(alumno);

                Evaluaciones evaluacion = Evaluaciones.Evaluar(alumno, docente, aulas.ElementAt(index));
                Alumno.Guardar(alumno, evaluacion.NotaFinal);
                ManejadorSQL.CargarCalificaciones(evaluacion);
                
            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            
            //if (!hiloEvaluacion.IsAlive && flag == 0)
            //{
                //hiloEvaluacion.Start();
                //flag = 1;
            //}

            //ActualizarListaRecreo();
        }

        /// <summary>
        /// Metodo que actualiza el richtextbos de los alumnos que ya pueden ir al recreo
        /// </summary>
        public void ActualizarListaRecreo()
        {
            try
            {
                if (alumnos.Count > 0)
                {
                    if (rctAlumnosEnRecreo.InvokeRequired)
                    {
                        rctAlumnosEnRecreo.BeginInvoke((MethodInvoker)delegate ()
                        {
                            rctAlumnosEnRecreo.Clear();
                            foreach (Alumno auxAlumno in alumnos)
                            {

                                rctAlumnosEnRecreo.AppendText(string.Format("{0} {1}\n", auxAlumno.Nombre.ToString(), auxAlumno.Apellido.ToString()));
                            }
                        });
                    }
                    else
                    {
                        rctAlumnosEnRecreo.Clear();
                        foreach (Alumno auxAlumno in alumnos)
                        {

                            rctAlumnosEnRecreo.AppendText(string.Format("{0} {1}\n", auxAlumno.Nombre.ToString(), auxAlumno.Apellido.ToString()));
                        }
                    }
                    
                }
            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            //hiloEvaluacion.Abort();
        }
        #endregion

        

        
         
       


    }
}

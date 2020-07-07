using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    [Serializable]
    public class Alumno : Persona
    {

        private int idAlumno;

        /// <summary>
        /// Propiedad que setea o devuelve el id del alumno
        /// </summary>
        public int Id
        {
            get 
            { 
                return this.idAlumno; 
            }
            set 
            { 
                this.idAlumno = value; 
            }
        }

        #region Constructores
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Alumno() : base()
        {

        }

        /// <summary>
        /// Constructor que setes atributos del alumno, llamando al de persona
        /// </summary>
        /// <param name="nombre">Parametro, que se cargara al nombre</param>
        /// <param name="apellido">Parametro, que se cargara al apellido</param>
        /// <param name="dni">Parametro, que se cargara al dni</param>
        /// <param name="direccion">Parametro, que se cargara a la direccion</param>
        /// <param name="edad">Parametro, que se cargara a la edad del alumno</param>
        /// <param name="idAlumno">Parametro, que se cargara al id del alumno</param>
        public Alumno(string nombre, string apellido, int dni, string direccion, int edad, int idAlumno)
            : base(nombre, apellido, dni, direccion, edad)
        {
            this.Id = idAlumno;
        }

        #endregion


        #region Metodos
        /// <summary>
        /// Utiliza el metodo de la base para mostrar todos los atributos del alumno
        /// </summary>
        /// <returns>Cadena con los datos del alumno</returns>
        public override string MostrarDatos()
        {
            return base.ToString();
        }

        /// <summary>
        /// Metodo que serializara en xml el alumno
        /// </summary>
        /// <param name="alumno">Alumno que se serializara</param>
        /// <param name="evaluacion">Nota para saber si esta aprobado o no</param>
        /// <returns>Si pudo guardar devuelve true sino false</returns>
        public static bool Guardar(Alumno alumno, float nota)
        {
            Serializacion<Alumno> archivo = new Serializacion<Alumno>();
            string pathDirectoryAprobados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\Aprobados";
            string pathDirectoryDesaprobados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\Desaprobados";
            string pathDirectoryUnitTest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\PruebasUnitTest\XML";

            string nombreAprobados = string.Format(@"\{0}_{1}_{2}_{3}_{4}.xml", alumno.Nombre, alumno.Apellido, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string nombreDesaprobados = string.Format(@"\{0}_{1}_{2}_{3}_{4}.xml", alumno.Nombre, alumno.Apellido, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string nombrePruebaUnitTest = string.Format(@"\{0}_{1}_{2}_{3}_{4}.xml", alumno.Nombre, alumno.Apellido, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);



            if (nota == 11)
            {
                return archivo.Guardar(pathDirectoryUnitTest, nombrePruebaUnitTest, alumno);
            }
            if (nota >= 7 && nota <= 10)
            {
                return archivo.Guardar(pathDirectoryAprobados, nombreAprobados, alumno);
            }
            else
            {
                return archivo.Guardar(pathDirectoryDesaprobados, nombreDesaprobados, alumno);
            }

        }


        #endregion


    }
}

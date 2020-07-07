using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {

        private int idAlumno;

        /// <summary>
        /// 
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

        public Alumno():base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>
        /// <param name="edad"></param>
        /// <param name="idAlumno"></param>
        public Alumno(string nombre,string apellido,int dni,string direccion,int edad,int idAlumno)
            :base(nombre,apellido,dni,direccion,edad)
        {
            this.Id = idAlumno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            return base.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="evaluacion"></param>
        /// <returns></returns>
        public static bool Guardar(Alumno alumno,float nota)
        {
            Serializacion<Alumno> archivo = new Serializacion<Alumno>();
            string pathDirectoryAprobados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ @"\SegundoParcialUtn\JardinUtn\Serializaciones\Aprobados";
            string pathDirectoryDesaprobados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ @"\SegundoParcialUtn\JardinUtn\Serializaciones\Desaprobados";

            string nombreAprobados = string.Format(@"\{0}_{1}_{2}_{3}_{4}.xml", alumno.Nombre, alumno.Apellido, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string nombreDesaprobados = string.Format(@"\{0}_{1}_{2}_{3}_{4}.xml", alumno.Nombre, alumno.Apellido, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
          
            if(nota >= 7 && nota <= 10)
            {
                return archivo.Guardar(pathDirectoryAprobados, nombreAprobados, alumno);
            }
            else
            {
                return archivo.Guardar(pathDirectoryDesaprobados, nombreDesaprobados, alumno);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno turno;

        //CONSTRUCTOR
        public Aula(EColores colorSala, ETurno turno, Docente docente)
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
            alumnos = new List<Alumno>();
        }

        #region PROPIEDADES:

        /// <summary>
        /// Devuelve o setea una lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get 
            {
                return alumnos;
            }
            set 
            { 
                alumnos = value; 
            }
        }

        /// <summary>
        /// Devuelve o setea el enumerado color de sala
        /// </summary>
        public EColores ColorSala
        {
            get 
            { 
                return this.colorSala; 
            }
            set 
            { 
                this.colorSala = value; 
            }
        }


        /// <summary>
        /// Devuelve o setea el docente
        /// </summary>
        public Docente Docente
        {
            get 
            { 
                return this.docente; 
            }
            set 
            { 
                this.docente = value; 
            }
        }

        /// <summary>
        /// Devuelve o setea el turno del aula
        /// </summary>
        public ETurno Turno
        {
            get 
            { 
                return this.turno; 
            }
            set 
            { 
                this.turno = value; 
            }
        }

        #endregion

        #region METODOS:

        /// <summary>
        /// Agrega un alumno a su lista de alumnos, si corresponde con el mismo color de sala
        /// </summary>
        /// <param name="aula">Aula a la cual se cargar el alumno</param>
        /// <param name="alumno">Alumno a cargar</param>
        /// <returns>True si pudo agregar sino false</returns>
        public static bool operator +(Aula aula, Alumno alumno)
        {
            bool retorno = false;
            if (aula.alumnos.Count >= 0 && aula.alumnos.Count <= 30)
            {
                //foreach (Alumno aux in aula.alumnos)
                ///{
                    if (alumno.ColorSala == aula.ColorSala)
                    {
                        aula.alumnos.Add(alumno);
                        retorno = true;
                    }

                //}
            }
            return retorno;
        }

        #endregion
    }
}

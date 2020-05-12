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

        //PROPIEDADES:
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

        //METODOS:

        public static bool operator +(Aula aula, Alumno alumno)
        {
            bool retorno = false;
            if(aula.alumnos.Count > 0 && aula.alumnos.Count <= 30)
            {
                foreach (Alumno aux in aula.alumnos)
                {
                    if(alumno.ColorSala == aula.ColorSala)
                    {
                        aula.alumnos.Add(alumno);
                        retorno = true;
                    }
                    
                }
            }
            return retorno;
        }
    }
}

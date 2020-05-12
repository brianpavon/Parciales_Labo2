using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;


        //CONSTRUCTOR
        public Alumno(string nombre, string apellido,int dni, bool femenino, float precioCuota):base(nombre,apellido,dni,femenino)
        {
            this.precioCuota = precioCuota;
            
        }

        #region PROPIEDADES

        /// <summary>
        /// Setea o devuelve el color de la sala
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
        /// Setea o devuelve el legajo
        /// </summary>
        public int Legajo
        {
            get 
            {
                return this.legajo; 
            }
            set 
            {
                this.legajo = value;
            }
        }

        /// <summary>
        /// Setea o devuelve la cuota pagada del alumno
        /// </summary>
        public float PrecioCuota
        {
            get 
            {
                return this.precioCuota;
            }
            set 
            {
                this.precioCuota = value; 
            }
        }


        /// <summary>
        /// Setea o devuelve el Responsable del alumno
        /// </summary>
        public Responsable Responsable
        {
            get 
            {
                return this.responsable;
            }
            set 
            {
                this.responsable = value; 
            }
        }

        #endregion


        #region METODOS:

        /// <summary>
        /// Si dos alumnos tienen el mismo legajo son iguales
        /// </summary>
        /// <param name="alumnoUno">Primer elemento a comparar</param>
        /// <param name="alumnoDos">segundo elemento a comparar</param>
        /// <returns>Devuelve true si lo son si no false</returns>
        public static bool operator == (Alumno alumnoUno, Alumno alumnoDos)
        {
            
            if (!(alumnoUno is null))
            {
                return alumnoUno.legajo == alumnoDos.legajo;
            }           
            return false;           

        }

        /// <summary>
        /// Verifica que 2 alumnos sean distintos
        /// </summary>
        /// <param name="alumnoUno">Primer objeto a compaarar</param>
        /// <param name="alumnoDos">Segundo objeto a comparar</param>
        /// <returns>True si son distintos sino false</returns>
        public static bool operator != (Alumno alumnoUno,Alumno alumnoDos) 
        {
            return !(alumnoUno == alumnoDos);
        }


        /// <summary>
        /// Al castear devuelve el responsable del alumno
        /// </summary>
        /// <param name="alumno">El alumno a castear</param>
        public static implicit operator Responsable(Alumno alumno)
        {
            return alumno.Responsable;
        }


        /// <summary>
        /// Redifinicion del to string que hereda de la clase persona, mostrando todos sus atributos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Color Sala {this.colorSala}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Valor de la cuota: {this.precioCuota}");
            sb.AppendLine($"Responsable del alumno: {this.responsable}");

            return sb.ToString();
            
        }

        #endregion
    }
}

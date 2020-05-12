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

        //PROPIEDADES
        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }

        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        //METODOS:
        public static bool operator == (Alumno alumnoUno, Alumno alumnoDos)
        {
            
            if (!(alumnoUno is null))
            {
                return alumnoUno.legajo == alumnoDos.legajo;
            }           
            return false;           

        }

        public static bool operator != (Alumno alumnoUno,Alumno alumnoDos) 
        {
            return !(alumnoUno == alumnoDos);
        }

        public static implicit operator Responsable(Alumno alumno)
        {
            return alumno.Responsable;
        }

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
    }
}

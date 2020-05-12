using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public abstract class Personal : Persona
    {

        /*DateTime d = new DateTime(01,01,01,hora,00,00);
         *y hace magia
         *Eze Oggioni21:40
         *d.Hour devuelve la hora y con el metodo AddHours se puede restar o sumar
         */
        private DateTime horaEntrada;
        private DateTime horaSalida;

        //CONSTRUCTOR
        public Personal(string nombre,string apellido,int dni,bool femenino, DateTime horaEntrada, DateTime horaSalida):base(nombre,apellido,dni,femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }

        #region PROPIEDADES

        /// <summary>
        /// Setea o devuelve la hora de entrada
        /// </summary>
        public DateTime HoraEntrada
        {
            get 
            {
                return this.horaEntrada; 
            }
            set
            {
                this.horaEntrada = value;
            }
        }


        /// <summary>
        /// Setea o devuelve la hora de salida
        /// </summary>
        public DateTime HoraSalida
        {
            get 
            {
                return this.horaSalida; 
            }
            set
            {
                this.horaSalida = value;
            }
        }

        /// <summary>
        /// Devuelve el salario
        /// </summary>
        public double Salario
        {
            get { return CalcularSalario(); }
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo que implementaran las clases que la hereden
        /// </summary>
        /// <returns>Devolvera el salario de acuerdo a su tipoo cargo</returns>
        public abstract double CalcularSalario();

        /// <summary>
        /// Redefine el tostring con sus atributos
        /// </summary>
        /// <returns>Devuelve un string con sus atributos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Hora entrada: {this.horaEntrada}");
            sb.AppendLine($"Hora salida: {this.horaSalida}");
            sb.AppendLine($"Salario: {this.CalcularSalario().ToString()}");

            return sb.ToString();
        }

        #endregion

    }
}

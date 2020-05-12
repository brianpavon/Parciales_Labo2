using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        private double valorHora;

        //CONSTRUCTOR:
        public Docente(string nombre,string apellido,int dni,bool femenino,DateTime horaEntrada,DateTime horaSalida,
                       double valorHora):base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.valorHora = valorHora;

        }


        #region PROPIEDADES:

        /// <summary>
        /// Setea y devuelve las horas mensuales del docente
        /// </summary>
        public int HorasMensuales
        {
            get 
            {
                int horasMensuales;

                return horasMensuales = (this.HoraSalida.Hour - this.HoraEntrada.Hour)*20;
                //return horasMensuales * 20;
            
            }
        }

        /// <summary>
        /// Setea o devuelve el valor de la hora del docente
        /// </summary>
        public double ValorHora
        {
            get
            { 
                return this.valorHora; 
            }
            set 
            {
                this.valorHora = value;
            }
        }

        #endregion

        #region METODOS:

        /// <summary>
        /// Redefine metodo calcular salario por ser docente
        /// </summary>
        /// <returns>Devuelve el salario</returns>
        public override double CalcularSalario()
        {
            double salarioMensual;
            return salarioMensual = valorHora * HorasMensuales;           
        }

        /// <summary>
        /// Reefinicion del Tostring donde mostrara todos sus atributos
        /// </summary>
        /// <returns>Retorna un string con sus datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Horas mensuales: {this.HorasMensuales}");

            
            return sb.ToString();
        }

        #endregion
    }
}

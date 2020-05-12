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

        //PROPIEDADES:
        public int HorasMensuales
        {
            get 
            {
                int horasMensuales;

                return horasMensuales = (this.HoraSalida.Hour - this.HoraEntrada.Hour)*20;
                //return horasMensuales * 20;
            
            }
        }

        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }

        //METODOS:

        public override double CalcularSalario()
        {
            double salarioMensual;
            return salarioMensual = valorHora * HorasMensuales;           
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Horas mensuales: {this.HorasMensuales}");
            
            return sb.ToString();
        }
    }
}

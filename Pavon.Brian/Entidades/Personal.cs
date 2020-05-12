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

        //PROPIEDADES
        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        public double Salario
        {
            get { return CalcularSalario(); }
        }

        public abstract double CalcularSalario();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Hora entrada: {this.horaEntrada}");
            sb.AppendLine($"Hora salida: {this.horaSalida}");

            return sb.ToString();
        }


    }
}

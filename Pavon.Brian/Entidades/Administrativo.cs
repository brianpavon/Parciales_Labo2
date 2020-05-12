using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
        private ECargo cargo;
        private static double salarioBase;

        //CONSTRUCTOR
        public Administrativo(string nombre,string apellido,int dni,bool femenino,DateTime horaEntrada,
                              DateTime horaSalida,ECargo cargo):base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.cargo = cargo;
        }

        /// <summary>
        /// Setea el sueldo en 30mil
        /// </summary>
        static Administrativo()
        {
            salarioBase = 30000;
        }

        #region Propiedades
        //PROPIEDADES

        /// <summary>
        /// Setea o devuelve elcargo
        /// </summary>
        public ECargo Cargo
        {
            get 
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        #endregion

        #region Metodos

        //METODO
        /// <summary>
        /// Redefine el calcular salario de acuerdo al cargo
        /// </summary>
        /// <returns></returns>
        public override double CalcularSalario()
        {
            double salarioTotal = 0;
            
            switch (this.cargo)
            {
                case ECargo.Cocina:
                    salarioTotal = salarioBase * (double)ECargo.Cocina / 100;
                    break;
                case ECargo.Direccion:
                    salarioTotal = salarioBase * (double)ECargo.Direccion / 100;
                    break;
                case ECargo.Porteria: 
                    salarioTotal = salarioBase * (double)ECargo.Porteria / 100;
                    break;
                case ECargo.Secretaria:
                    salarioTotal = salarioBase * (double)ECargo.Secretaria / 100;
                    break;
                case ECargo.Tesoreria:
                    salarioTotal = salarioBase * (double)ECargo.Tesoreria / 100;
                    break;
                default:
                    break;

            }       

            return salarioTotal;
        }

        /// <summary>
        /// Redefine el toString devolviendo sus atributos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cargo {this.cargo}");
            sb.AppendLine($"Salario: {this.Salario}");

            return sb.ToString();
        }

        #endregion

    }
}

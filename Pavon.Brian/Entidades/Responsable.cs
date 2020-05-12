using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsable : Persona
    {
        private EParentezco parentezco;
        private string telefono;

        //CONSTRUCTORES:
        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentezco parentezco, string telefono):base(nombre,apellido,dni,femenino)
        {
            this.parentezco = parentezco;
            this.telefono = telefono;
        }

        //PROPIEDADES:
        public EParentezco Parentezco
        {
            get 
            { 
                return this.parentezco; 
            }
            set 
            { 
                this.parentezco = value; 
            }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Parentezco con el alumno: {this.parentezco}");
            sb.AppendLine($"Telefono: {this.telefono}");

            return sb.ToString();
        }


    }
}

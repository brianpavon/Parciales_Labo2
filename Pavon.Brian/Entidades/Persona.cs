using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private bool femenino;
        private string nombre;

        //CONSTRUCTORES:

        public Persona(string nombre, string apellido,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, int dni, bool femenino):this(nombre,apellido,dni)
        {
            this.femenino = femenino;
        }

        //PROPIEDADES:

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"DNI: {this.dni}");
            if (this.femenino == true)
            {
                sb.AppendLine($"Sexo Femenino");
            }
            else
            {
                sb.AppendLine("Sexo Masculino");
            }

            return sb.ToString();
        }
       


    }
}

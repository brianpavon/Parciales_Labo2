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

        #region PROPIEDADES:

        /// <summary>
        /// Setea o devuelve el apellido
        /// </summary>
        public string Apellido
        {
            get 
            {
                return this.apellido;
            }
            set 
            { 
                this.apellido = value;
            }
        }


        /// <summary>
        /// Setea o devuelve el dni
        /// </summary>
        public int Dni
        {
            get 
            {
                return this.dni; 
            }
            set 
            { 
                this.dni = value;
            }
        }


        /// <summary>
        /// Setea o devuelve el booleano en femenino, true si lo es
        /// </summary>
        public bool Femenino
        {
            get 
            {
                return this.femenino;
            }
            set 
            {
                this.femenino = value;
            }
        }


        /// <summary>
        /// Setea o devuelve el nombre
        /// </summary>
        public string Nombre
        {
            get 
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value;
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Redfine el metodo to string con sus atributos
        /// </summary>
        /// <returns>Devuelve un string con sus atributos</returns>
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

        #endregion



    }
}

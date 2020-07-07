using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private string direccion;
        private string nombre;
        private int edad;
        

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor que seteara los atributos de la persona
        /// </summary>
        /// <param name="nombre">Parametro que se cargara al nombre</param>
        /// <param name="apellido">Parametro que se cargara al apellido</param>
        /// <param name="dni">Parametro que se cargara al dni</param>
        /// <param name="direccion">Parametro que se cargara a la direccion</param>
        /// <param name="edad">Parametro que se cargara a la edad</param>
        public Persona(string nombre, string apellido,int dni,string direccion,int edad):this()
        {
            this.Edad = edad;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Direccion = direccion;
        }
        #endregion

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
        /// Setea o devuelve la edad
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }


        /// <summary>
        /// Setea o devuelve el booleano en femenino, true si lo es
        /// </summary>
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
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
            sb.AppendLine($"Direccion: {this.direccion}");            

            return sb.ToString();
        }

        /// <summary>
        /// Metodo a implementar por las clases que lo hereden, para mostrar los datos
        /// </summary>
        /// <returns></returns>
        public abstract string MostrarDatos();

        #endregion



    }
}


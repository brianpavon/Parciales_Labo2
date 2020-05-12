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

        #region PROPIEDADES:

        /// <summary>
        /// Setea o devuelve el parentezco
        /// </summary>
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

        /// <summary>
        /// Setea o devuelve el telefono
        /// </summary>
        public string Telefono
        {
            get 
            {
                return this.telefono;
            }
            set 
            {
                this.telefono = value; 
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Redefine el ToString cargando sus atributos
        /// </summary>
        /// <returns>Devuelve un string con sus datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Parentezco con el alumno: {this.parentezco}");
            sb.AppendLine($"Telefono: {this.telefono}");

            return sb.ToString();
        }
        #endregion


    }
}

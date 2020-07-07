using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionesPropias : Exception
    {
        
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public ExcepcionesPropias():base()
        {

        }

        /// <summary>
        /// Constructor que recibe un mensaje y pasa a su base
        /// </summary>
        /// <param name="mensaje">Parametro que guardara</param>
        public ExcepcionesPropias(string mensaje) : base(mensaje)
        {

        }

        /// <summary>
        /// Constructor que recibe un mensaje y una excepcion y pasa a su base
        /// </summary>
        public ExcepcionesPropias(string mensaje,Exception innerException) :base(mensaje,innerException)
        {

        }
    }
}

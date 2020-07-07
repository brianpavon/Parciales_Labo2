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
        /// 
        /// </summary>
        public ExcepcionesPropias():base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public ExcepcionesPropias(string mensaje) : base(mensaje)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public ExcepcionesPropias(string mensaje,Exception innerException) :base(mensaje,innerException)
        {

        }
    }
}

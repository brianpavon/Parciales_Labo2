using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static bool GuardarTxt(this string texto,string nombre)
        {
            bool retorno = false;
            string pathLog = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Errores\";
            try
            {
                
                if (!Directory.Exists(pathLog))
                {
                    Directory.CreateDirectory(pathLog);
                    throw new ExcepcionesPropias("Se creo el directorio para los errores");
                }
                if (!File.Exists(pathLog + nombre))
                {
                    FileStream file = File.Create(pathLog + nombre);
                    file.Close();
                    throw new ExcepcionesPropias("Se creo el archivo log");
                }
                using (StreamWriter writer = new StreamWriter(pathLog + nombre, true))
                {
                    writer.WriteLine(texto);
                    retorno = true;
                }
            }
            catch(ExcepcionesPropias ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            
            return retorno;
        }
    }
}

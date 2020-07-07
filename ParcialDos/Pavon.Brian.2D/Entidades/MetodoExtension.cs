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
        /// Metodo de extension que permite a un string guardar en un txt su mensaje
        /// </summary>
        /// <param name="texto">String que guardara en el txt</param>
        /// <param name="nombre">Nombre del archivosque se creara</param>
        /// <returns>Si pudo guardar devuelve true sino false</returns>
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Entidades
{
    public static class SerializacionBinaria
    {
        static BinaryFormatter ser;
        static Stream fs;

        /// <summary>
        /// Metodo que guardar datos en binario
        /// </summary>
        /// <param name="path">Ruta o nombre del directorio</param>
        /// <param name="nombre">Nombre del archico a guardar</param>
        /// <param name="Alumno">Alumno que se pasara para serializar en binario</param>
        /// <returns></returns>
        public static bool Guardar(string path, string nombre,Alumno a)
        {
            bool retorno = false;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    //throw new ExcepcionesPropias("No estaba creada la ruta, fue creada");
                }
                if (!File.Exists(path + nombre))
                {
                    FileStream file = File.Create(path + nombre);
                    file.Close();
                }
                ser = new BinaryFormatter();
                fs = new FileStream(path + nombre, FileMode.Create);

                ser.Serialize(fs, a);
                retorno = true;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                fs.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Metodo que lee un archivo binario y lo pasa a un Alumno
        /// </summary>
        /// <param name="archivo">Ruta o nombre de donde se leera el archivo</param>        
        /// <returns>Devuelve un alumno, luego de ser serializado de binario</returns>
        public static Alumno Leer(string archivo)
        {
            Alumno aux = null;
            try
            {
                fs = new FileStream(archivo, FileMode.Open);
                ser = new BinaryFormatter();
                aux = (Alumno)ser.Deserialize(fs);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                fs.Close();
            }
            return aux;
            
        }
    }
}

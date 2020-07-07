using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    /// <summary>
    /// Clase que implementa la interfaz IArchivo para guardar y leer en XML
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Serializacion<T> : IArchivo<T>
    {

        /// <summary>
        /// Metodo que serializa un objeto
        /// </summary>
        /// <param name="path">Ruta o nombre del directorio</param>
        /// <param name="nombre">Nombre del archivo</param>
        /// <param name="datos">Objeto a serializar</param>
        /// <returns>Si pudo serializar devuelve true sino false</returns>
        public bool Guardar(string path,string nombre, T datos)
        {
            bool retorno = false;
            try
            {
                
                if (!(String.IsNullOrEmpty(path)) || !object.ReferenceEquals(datos, null))
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        throw new ExcepcionesPropias("No estaba creada la ruta, fue creada");
                    }
                    if (!File.Exists(path + nombre))
                    {
                        FileStream file = File.Create(path + nombre);
                        file.Close();
                    }
                    using (XmlTextWriter writer = new XmlTextWriter(path + nombre, Encoding.UTF8))
                    {
                        XmlSerializer sr = new XmlSerializer(typeof(T));
                        sr.Serialize(writer, datos);
                        retorno = true;
                    }
                }
                else
                {
                    throw new Exception("No se pudo guardar el archivo");
                }
            }
            catch (ExcepcionesPropias ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            return retorno;
        }

        /// <summary>
        /// Metodo para deserializar un archivo xml
        /// </summary>
        /// <param name="archivo">Nombre del archivo a deserializar</param>
        /// <param name="datos">Objeto al cual se le pasaran los datos</param>
        /// <returns>Si pudo deserializar devuelve true sino false</returns>
        public bool Leer(string archivo, out T datos)
        {

            bool retorno = false;

            if (!(String.IsNullOrEmpty(archivo)))
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer deserialiazar = new XmlSerializer(typeof(T));
                    datos = (T)deserialiazar.Deserialize(reader);
                    retorno = true;
                }
            }
            else
            {
                throw new ExcepcionesPropias("No se puede leer el archivo");
            }

            return retorno;
        }

        
    }
}

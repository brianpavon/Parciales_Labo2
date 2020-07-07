using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestingJardin
{
    [TestClass]
    public class TestSerializacion
    {
        /// <summary>
        /// Test que evaluara que se pueda serializar en xml un alumno
        /// </summary>
        [TestMethod]
        public void ProbarSerializacionXML()
        {
            Queue<Alumno> colaAlumnos = new Queue<Alumno>();
            colaAlumnos = ManejadorSQL.ObtenerDatosAlumno("select * from alumnos");
            bool retorno = false;
            foreach (Alumno auxAlumno in colaAlumnos)
            {
               //paso nota 11 asi pruebo en una carpeta aparte donde se guardan
                retorno = Alumno.Guardar(auxAlumno, 11);
                
            }

            Assert.IsTrue(retorno);
        }


        /// <summary>
        /// Test que evaluara que se pueda deserializar en xml un alumno
        /// </summary>
        [TestMethod]
        public void ProbarDeserializacionXML()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\PruebasUnitTest\XML\Adel_Guymer_7_7_2020.xml";
            bool retorno = false;
            Alumno alumnoPrueba = new Alumno();
            Serializacion<Alumno> deserializarAlumno = new Serializacion<Alumno>();
            retorno = deserializarAlumno.Leer(path, out alumnoPrueba);
            Assert.IsTrue(retorno);
        }

        /// <summary>
        /// Test que evaluara que se pueda serializar en binario un alumno
        /// </summary>
        [TestMethod]
        public void ProbarSerializacionBinario()
        {
            bool retorno = false;
            Alumno probarBinario = new Alumno("Prueba", "Binario", 359689, "No hay dire", 3, 2);
            string pathDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\PruebasUnitTest\Binarias";
            string nombreArchivo = string.Format(@"\{0}_{1}_{2}_{3}_{4}.dat", probarBinario.Nombre, probarBinario.Apellido, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);


            retorno = SerializacionBinaria.Guardar(pathDirectory, nombreArchivo, probarBinario);

            Assert.IsTrue(retorno);
        }


        /// <summary>
        /// Test que evaluara que se pueda deserializar en binario un alumno
        /// </summary>
        [TestMethod]
        public void ProbarDeserializacionBinario()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\PruebasUnitTest\Binarias\Prueba_Binario_7_7_2020.dat";
            Alumno pruebaBinario = SerializacionBinaria.Leer(path);
            

            Assert.IsNotNull(pruebaBinario);
        }
    }
}

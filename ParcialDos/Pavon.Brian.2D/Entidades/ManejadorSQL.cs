using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class ManejadorSQL
    {
        
        static SqlConnection miConexion;
        static SqlCommand miComando;
        static SqlDataReader leer;

        /// <summary>
        /// Se inician las conexiones y se pasa la misma al comando
        /// </summary>
        static ManejadorSQL()
        {
            try
            {
                miConexion = new SqlConnection();
                miConexion.ConnectionString = @"Data Source = LAPTOP-Q1OJ1113\SQLEXPRESS01; Initial Catalog = JardinUtn; Integrated Security = True";
                miComando = new SqlCommand();
                miComando.Connection = miConexion;
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            
        }

        #region Metodos
        /// <summary>
        /// Metodo que devuelve una lista de Aulas, estrayendolas de la base de datos
        /// </summary>
        /// <param name="consulta">Cadena que se introduce como consutla de SQL</param>
        /// <returns>Devuelve una lista con Aulas</returns>
        public static List<Aula> CargarAulas(string consulta)
        {
            List<Aula> listaAuxiliar = new List<Aula>();
            try
            {
                //SqlDataReader leer;
                //SqlCommand miComando = new SqlCommand();
                //miComando.Connection = miConexion;
                miComando.CommandText = consulta;
                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                    leer = miComando.ExecuteReader();
                    while (leer.Read())
                    {
                        listaAuxiliar.Add(new Aula((int)leer[0],leer[1].ToString()));
                    }
                }
                
            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }
            return listaAuxiliar;
        }

        /// <summary>
        /// Devuevle un DataTable, de la tabla obtenida de la base de datos
        /// </summary>
        /// <param name="consulta">Consulta que se realizara en la base de datos</param>
        /// <returns>Devuelve la DataTable con la tabla del SQL</returns>
        public static DataTable RealizarConsulta(string consulta)
        {
            DataTable tablaAux = new DataTable();            
            try
            {
                //SqlDataReader leer;
                //SqlCommand miComando = new SqlCommand();
                //miComando.Connection = miConexion;
                miComando.CommandText = consulta;
                if(miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                    leer = miComando.ExecuteReader();
                    tablaAux.Load(leer);
                }

            }
            catch (Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            finally
            {
                if(miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return tablaAux;
        }

        /// <summary>
        /// Metodo que devuelve una Cola de Alumnos, extrayendo los datos de la base de datos
        /// </summary>
        /// <param name="consulta">Consulta a realizar en SQL</param>
        /// <returns>Cola con los alumnos</returns>
        public static Queue<Alumno> ObtenerDatosAlumno(string consulta)
        {
            //List<Alumno> auxiliarAlumnos = new List<Alumno>();
            Queue<Alumno> colaAlumnos = new Queue<Alumno>();
            try
            {
                //SqlDataReader leer;
                //SqlCommand miComando = new SqlCommand();
                //miComando.Connection = miConexion;
                miComando.CommandText = consulta;
                if(miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                    leer = miComando.ExecuteReader();
                    while (leer.Read())
                    {
                        //auxiliarAlumnos.Add(new Alumno(leer[1].ToString(),leer[2].ToString(),(int)leer[4],leer[5].ToString(),(int)leer[3],(int)leer[0]));
                        colaAlumnos.Enqueue(new Alumno(leer[1].ToString(),leer[2].ToString(),(int)leer[4],leer[5].ToString(),(int)leer[3],(int)leer[0]));
                    }
                }

            }
            catch(Exception ex)
            {
                ex.Message.GuardarTxt("log.txt");
            }
            finally
            {
                if(miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return colaAlumnos;
        }

        /// <summary>
        /// Metodo que introduce un docente en la base de datos
        /// </summary>
        /// <param name="docente">Docente que se cargara en la base de datos</param>
        /// <returns>Si pudo insertar devuelve true sino false</returns>
        public static bool InsertarDocente(Docente docente)
        {
            bool retorno = false;
            int inserto = -1;
            try
            {
                if(miConexion.State != ConnectionState.Open)
                {
                    miComando.Parameters.Clear();
                    miConexion.Open();
                    //SqlCommand miComando = new SqlCommand();
                    //miComando.Connection = miConexion;
                    miComando.CommandText = "insert into Docentes (Nombre,Apellido,Edad,Sexo,Dni,Direccion,Email) " +
                                            "values (@Nombre,@Apellido,@Edad,@Sexo,@Dni,@Direccion,@Email)";
                    miComando.Parameters.Add(new SqlParameter("Nombre", docente.Nombre));
                    miComando.Parameters.Add(new SqlParameter("Apellido", docente.Apellido));
                    miComando.Parameters.Add(new SqlParameter("Edad", docente.Edad));
                    miComando.Parameters.Add(new SqlParameter("Sexo", docente.Sexo));
                    miComando.Parameters.Add(new SqlParameter("Dni", docente.Dni));
                    miComando.Parameters.Add(new SqlParameter("Direccion", docente.Direccion));
                    miComando.Parameters.Add(new SqlParameter("Email", docente.Email));
                    inserto = miComando.ExecuteNonQuery();
                    if(inserto != -1)
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar");
                    }

                }
            }
            catch (Exception ex)
            {

                ex.Message.GuardarTxt("log.txt");
            }
            finally
            {
                miConexion.Close();
            }
            return retorno;
        }


        /// <summary>
        /// Metodo que sube a la base de datos las evaluaciones
        /// </summary>
        /// <param name="evaluacion">Evaluacion a cargarse en la base de datos</param>
        /// <returns>Si pudo cargar la evaluacion devuelve true sino false</returns>
        public static bool CargarCalificaciones(Evaluaciones evaluacion)
        {
            bool retorno = false;
            int inserto = -1;
            try
            {
                //SqlCommand miComando = new SqlCommand();
                miComando.Parameters.Clear();
                miConexion.Open();
                //miComando.Connection = miConexion;
                miComando.CommandText = "insert into Evaluaciones (idAlumno,idDocente,idAula,Nota_1,Nota_2,NotaFinal,Observaciones) " +
                                        "values(@idAlumno,@idDocente,@idAula,@Nota_1,@Nota_2,@NotaFinal,@Observaciones)";

                miComando.Parameters.Add(new SqlParameter("idAlumno", evaluacion.IdAlumno));
                miComando.Parameters.Add(new SqlParameter("idDocente", evaluacion.IdDocente));
                miComando.Parameters.Add(new SqlParameter("idAula", evaluacion.IdAula));
                miComando.Parameters.Add(new SqlParameter("Nota_1", evaluacion.NotaUno));
                miComando.Parameters.Add(new SqlParameter("Nota_2", evaluacion.NotaDos));
                miComando.Parameters.Add(new SqlParameter("NotaFinal", evaluacion.NotaFinal));
                miComando.Parameters.Add(new SqlParameter("Observaciones", evaluacion.Observaciones));

                inserto = miComando.ExecuteNonQuery();
                if(inserto != -1)
                {
                    retorno = true;
                }
                

            }
            catch (Exception ex)
            {

                ex.Message.GuardarTxt("log.txt");
            }
            finally
            {
                miConexion.Close();
            }
            return retorno;
        }
#endregion

        #region CodigoFeo
        ///
        //public static bool InsertarDocentes(string consulta, List<SqlParameter> parametros)
        //{
        //    bool retorno = false;
        //    int inserto = -1;
        //    try
        //    {
        //        miConexion.Open();
        //        SqlCommand miComando = new SqlCommand();
        //        miComando.Connection = miConexion;
        //        //miComando.CommandText = consulta;
        //        //foreach (SqlParameter item in parametros)
        //        //{
        //        //    //consulta += " @ "+ item.ToString() +",";
        //        //    miComando.Parameters.Add(item);
        //        //}
        //        for (int i = 0; i < parametros.Count; i++)
        //        {
        //            if (i == 0)
        //            {
        //                consulta += " (@" + parametros[i].ToString() + ",";
        //                miComando.Parameters.Add(parametros[i]);
        //            }
        //            else if (i > 0 && i < parametros.Count - 1)
        //            {
        //                consulta += " @" + parametros[i].ToString() + ",";
        //                miComando.Parameters.Add(parametros[i]);
        //            }
        //            if (i == parametros.Count - 1)
        //            {
        //                consulta += " @" + parametros[i].ToString() + ")";
        //                miComando.Parameters.Add(parametros[i]);
        //            }
        //        }
        //        miComando.CommandText = consulta;
        //        inserto = miComando.ExecuteNonQuery();
        //        if(inserto != -1)
        //        {
        //            retorno = true;
        //        }


        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        if(miConexion.State != ConnectionState.Closed)
        //        {
        //            miConexion.Close();
        //        }
        //    }

        //    return retorno;
        //}


        #endregion

    }
}

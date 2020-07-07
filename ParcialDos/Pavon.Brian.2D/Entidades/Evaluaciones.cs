using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class Evaluaciones
    {
		
		
		private int idEvaluacion;
		private int idAlumno;
		private int idDocente;
		private int idAula;
		private int notaUno;
		private int notaDos;
		private float notaFinal;
		private string observaciones;

		#region Constructores
		/// <summary>
		/// Constructor sin parametros
		/// </summary>
		public Evaluaciones()
		{
			
		}

		/// <summary>
		/// Constructor que setea todos los atributos de la evaluacion
		/// </summary>
		/// <param name="idAlumno">Atributo que se seteara al id del alumno</param>
		/// <param name="idDocente">Atributo que se seteara al id del docente</param>
		/// <param name="idAula">Atributo que se seteara al id del aula</param>
		/// <param name="notaUno">Atributo que se seteara a la nota uno</param>
		/// <param name="notaDos">Atributo que se seteara a la nota dos</param>
		/// <param name="notaFinal">Atributo que se seteara a la nota final</param>
		/// <param name="observaciones">Atributo que se seteara a las observaciones</param>
		public Evaluaciones(int idAlumno, int idDocente, int idAula, int notaUno, int notaDos, float notaFinal, string observaciones):this()
		{
			this.IdAlumno = idAlumno;
			this.IdDocente = idDocente;
			this.IdAula = idAula;
			this.NotaUno = notaUno;
			this.NotaDos = notaDos;
			this.NotaFinal = notaFinal;
			this.Observaciones = observaciones;
		}

		#endregion



		#region Propiedades
		/// <summary>
		/// Propiedad que setea o devuelve las observaciones
		/// </summary>
		public string Observaciones
		{
			get
			{
				return this.observaciones;
			}
			set
			{
				this.observaciones = value;
			}
		}

		/// <summary>
		/// Propiedad que setea o devuelve la nota final
		/// </summary>
		public float NotaFinal
		{
			get
			{
				return this.notaFinal;
			}
			set
			{
				this.notaFinal = value;
			}
		}

		/// <summary>
		/// Propiedad que setea o devuelve la nota dos
		/// </summary>
		public int NotaDos
		{
			get
			{
				return this.notaDos;
			}
			set
			{
				this.notaDos = value;
			}
		}

		/// <summary>
		/// Propiedad que setea o devuelve la nota uno
		/// </summary>
		public int NotaUno
		{
			get
			{
				return this.notaUno;
			}
			set
			{
				this.notaUno = value;
			}
		}

		/// <summary>
		/// Propiedad que setea o devuelve el id del aula
		/// </summary>
		public int IdAula
		{
			get
			{
				return this.idAula;
			}
			set
			{
				this.idAula = value;
			}
		}

		/// <summary>
		/// Propiedad que setea o devuelve el id del docente
		/// </summary>
		public int IdDocente
		{
			get
			{
				return this.idDocente;
			}
			set
			{
				this.idDocente = value;
			}
		}

		/// <summary>
		/// Propiedad que setea o devuelve el id del alumno
		/// </summary>
		public int IdAlumno
		{
			get { return idAlumno; }
			set { idAlumno = value; }
		}

		/// <summary>
		/// Propiedad que setea o devuelve el id de la evaluacion
		/// </summary>
		public int IdEvaluacion
		{
			get { return idEvaluacion; }
			set { idEvaluacion = value; }
		}

		#endregion

		#region Metodos

		/// <summary>
		/// Metodo que devuelve una evaluacion, recibiendo datos del docente, alumno y aula, y haciendo el promedio de notas
		/// </summary>
		/// <param name="alumno">Alumnos del cual se sacara el id del alumno</param>
		/// <param name="docente">Alumnos del cual se sacara el id del docente</param>
		/// <param name="aula">Alumnos del cual se sacara el id del aula</param>
		/// <returns>Devuelve una Evaluacion</returns>
		public static Evaluaciones Evaluar(Alumno alumno, Docente docente,Aula aula)
		{
			//bool retorno = false;
			Random notaAleatoria = new Random();
			int notaUno = notaAleatoria.Next(0, 10);
			int notaDos = notaAleatoria.Next(0, 10);
			float notaFinal = (notaUno + notaDos) / 2;
			Evaluaciones evaluacion;
			try
			{
				if(!object.Equals(alumno,null) && !object.Equals(docente, null))
				{
					evaluacion = new Evaluaciones(alumno.Id, docente.Id,aula.IdAula, notaUno, notaDos, notaFinal, Evaluaciones.DevolverObservaciones(notaFinal));
					//retorno = true;
				}
				else
				{
					throw new Exception("No se puede dar de alta una evaluacion, sin docentes y alumnos");
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}

			return evaluacion;
		}

		/// <summary>
		/// Metodo que recorre del 1 al 10, y devuelve un string con un comentario
		/// </summary>
		/// <param name="nota">Numero que se pasara para obtener el comentario</param>
		/// <returns>Devuelve el comentario para cargar a la observacion</returns>
		public static string DevolverObservaciones(float nota)
		{
			string retorno = string.Empty;
			switch (nota)
			{
				case 0:
					retorno = "Muy Mal";
					break;
				case 1:
					retorno = "Mal";
					break;
				case 2:
					retorno = "Regular Menos";
					break;
				case 3:
					retorno = "Regular";
					break;
				case 4:
					retorno = "Regular Mas";
					break;
				case 5:
					retorno = "Bien Menos";
					break;
				case 6:
					retorno = "Bien";
					break;
				case 7:
					retorno = "Bien Mas";
					break;
				case 8:
					retorno = "Muy Bien";
					break;
				case 9:
					retorno = "Excelente";
					break;
				case 10:
					retorno = "Extraordinario";
					break;
			}
			return retorno;
		}

		#endregion



	}
}

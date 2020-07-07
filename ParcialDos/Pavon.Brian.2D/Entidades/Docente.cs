using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Persona
    {
		private string sexo;
		private string email;
		private int idDocente;

		
		#region Propiedades

		/// <summary>
		/// Propiedad que devuelve o setea el mail del Docente
		/// </summary>
		public string Email
		{
			get
			{
				return this.email;
			}
			set
			{
				this.email = value;
			}
		}

		/// <summary>
		/// Propiedad que devuelve o setea el sexo del Docente
		/// </summary>
		public string Sexo
		{
			get
			{
				return this.sexo;
			}
			set
			{
				this.sexo = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public int Id
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


		#endregion

		#region Constructores

		/// <summary>
		/// Constructor sin parametros
		/// </summary>
		public Docente():base()
		{
				
		}

		/// <summary>
		/// Constructor que seteara los atributos del docente
		/// </summary>
		/// <param name="nombre">Parametro que se seteara en el nombre</param>
		/// <param name="apellido">Parametro que se seteara en el apellido</param>
		/// <param name="dni">Parametro que se seteara en el dni</param>
		/// <param name="direccion">Parametro que se seteara en la direccion</param>
		/// <param name="edad">Parametro que se seteara en la edad</param>
		/// <param name="sexo">Parametro que se seteara en el sexo</param>
		/// <param name="mail">Parametro que se seteara en el mail</param>
		/// <param name="idDocente">Parametro que se seteara en el id del docente</param>
		public Docente(string nombre,string apellido,int dni,string direccion,int edad,string sexo,string mail,int idDocente)
			: base(nombre, apellido, dni, direccion, edad)
		{
			this.Sexo = sexo;
			this.Email = mail;
			this.Id = idDocente;
		}

		#endregion

		#region Metodos

		/// <summary>
		/// Metodo que utiliza muestra los datos del docente
		/// </summary>
		/// <returns>Devuelve una cadena con los datos del docente</returns>
		public override string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(base.ToString());
			sb.AppendLine($"Sexo: {this.sexo}");
			sb.AppendLine($"E-Mail: {this.Email}");
			sb.AppendLine($"-------------------------------");

			return sb.ToString();			
		}

		/// <summary>
		/// Metodo que devuelve una lista de SqlParameters, para pasar a un comando
		/// </summary>
		/// <param name="docente">Docente del cual se obtendran los datos</param>
		/// <returns>Devuelve una lista de SqlParameters</returns>
		public static List<SqlParameter> DevolverLosParametros(Docente docente)
		{
			List<SqlParameter> listaAuxiliar = new List<SqlParameter>();
			//listaAuxiliar.Add(new SqlParameter("idDocente", docente.IdDocente));
			listaAuxiliar.Add(new SqlParameter("Nombre", docente.Nombre));
			listaAuxiliar.Add(new SqlParameter("Apellido", docente.Apellido));
			listaAuxiliar.Add(new SqlParameter("Edad", docente.Edad));
			listaAuxiliar.Add(new SqlParameter("Sexo", docente.Sexo));
			listaAuxiliar.Add(new SqlParameter("Dni", docente.Dni));
			listaAuxiliar.Add(new SqlParameter("Direccion", docente.Direccion));
			listaAuxiliar.Add(new SqlParameter("Email", docente.Email));

			return listaAuxiliar;
		}


		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {

		private string salita;
		private int idAula;

		#region Propiedades
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
		/// Propiedad que setea o devuelve la descripcion del aula
		/// </summary>
		public string Salita
		{
			get
			{
				return this.salita;
			}
			set
			{
				this.salita = value;
			}
		}

		#endregion


		#region Constructores
		/// <summary>
		/// Constructor sin parametros
		/// </summary>
		public Aula()
		{

		}

		/// <summary>
		/// Constructor que setea el id y la descripcion
		/// </summary>
		/// <param name="id">Parametro que se seteara en el id</param>
		/// <param name="salita">Parametro que se seteara en la descripcion</param>
		public Aula(int id, string salita) : this()
		{
			this.IdAula = id;
			this.Salita = salita;
		}

		#endregion


		/// <summary>
		/// Metodo que utiliza el override del tostring para mostrar los datos del aula
		/// </summary>
		/// <returns>Devuelve una cadena con los datos del aula</returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Salita: {this.salita}");

			return sb.ToString();
		}
	}
}

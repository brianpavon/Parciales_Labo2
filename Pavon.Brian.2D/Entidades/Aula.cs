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

		/// <summary>
		/// 
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
		/// 
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

		public Aula()
		{

		}

		public Aula(int id,string salita):this()
		{
			this.IdAula = id;
			this.Salita = salita;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Salita: {this.salita}");

			return sb.ToString();
		}
	}
}

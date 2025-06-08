using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Ejemplo.Models
{
	public class Sala
	{
		public int ID_hospital { get; set; }

		public int ID_sala { get; set; }

		public string Nombre { get; set; }

		public int Num_camas { get; set; }

	}
}
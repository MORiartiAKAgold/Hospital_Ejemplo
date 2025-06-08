using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Ejemplo.Models
{
	public class Hospital
	{
		public int ID_hospital { get; set; }

		public string Nombre { get; set; }

		public string Direccion { get; set; }

		public int Telefono { get; set; }

		public int Num_camas { get; set; }

	}
}
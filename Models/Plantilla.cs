using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Ejemplo.Models
{
	public class Plantilla
	{
		public int ID_hospital { get; set; }

		public int ID_sala { get; set; }

		public int ID_empleado { get; set; }

		public string Funcion { get; set; }

		public string Turno { get; set; }

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Ejemplo.Models
{
	public class Doctor
	{
		public int ID_hospital { get; set; }

		public int ID_doctor { get; set; }

		public string Nombre { get; set; }
		
		public string Apellido { get; set; }

		public string Especialidad { get; set; }

	}
}
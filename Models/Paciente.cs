using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Ejemplo.Models
{
	public class Paciente
	{
		public int ID_paciente { get; set; }

		public string Nombre { get; set; }

		public string Apellido { get; set; }

		public DateTime Fecha_nacimiento { get; set; }

		public string Sexo { get; set; }

		public int NSS { get; set; }

	}
}
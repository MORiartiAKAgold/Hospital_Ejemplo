using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Ejemplo.Models
{
	public class Empleados
	{

        public int ID_Empleado { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public DateTime Fecha_alta { get; set; }

        public double Salario { get; set; }

        public double Comision { get; set; }

        public double ID_departamento { get; set; }

    }
}
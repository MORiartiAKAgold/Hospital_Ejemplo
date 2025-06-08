using Hospital_Ejemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_Ejemplo.Controllers
{
    public class EmpleadoController : Controller
    {
        #region Variables Globales
        List<Empleados> lsEmpleados
        #endregion
        {
            get
            {
                List<Empleados> lse = new List<Empleados>();
                var sEmp = Session["listaemp"];
                if (sEmp != null) lse = (List<Empleados>)sEmp;
                return lse;
            }
            set
            {
                Session["listaemp"] = value;
            }
        }
        // GET: Empleado
        public ActionResult Index()
        {
            try
            {
                if (lsEmpleados.Count() == 0)
                {
                    List<Empleados> ls = new List<Empleados>() { new Empleados
                    {
                        ID_Empleado = 1,
                        Nombre = "Ian",
                        Apellido = "Sanchez",
                        Comision = 0,
                        Direccion = "Conocida",
                        Fecha_alta = DateTime.Now,
                        ID_departamento = 1,
                        Salario = 10000
                    }};

                    lsEmpleados = ls;
                }
            }
            catch (Exception ex)
            {
                lsEmpleados = new List<Empleados>();
            }
            return View(lsEmpleados);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Empleados oEmp = new Empleados();
            return View(oEmp);
        }

        [HttpPost]
        public ActionResult Create(Empleados oEmp)
        {
            try
            {
                if (oEmp != null)
                {
                    if (!lsEmpleados.Any(e => e.ID_Empleado == oEmp.ID_Empleado))
                    {
                        lsEmpleados.Add(oEmp);
                        RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return View(oEmp);
        }

        [HttpGet]
        public ActionResult Edit(int ID_Empleado)
        {
            Empleados oEmp;
            try
            {
                oEmp = lsEmpleados.FirstOrDefault(a => a.ID_Empleado == ID_Empleado);
                if (oEmp == null) oEmp = new Empleados();
            }
            catch (Exception ex)
            {
                oEmp = new Empleados();
            }
            return View();
        }

        public ActionResult Edit(Empleados oEmp)
        {
            try
            {
                if (oEmp != null)
                {
                    Empleados oEmp2 = lsEmpleados.FirstOrDefault(a => a.ID_Empleado == oEmp.ID_Empleado);
                    if (oEmp2 != null)
                    {
                        lsEmpleados.Remove(oEmp2);
                        lsEmpleados.Add(oEmp);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return View(oEmp);
        }

        [HttpGet]
        public ActionResult Delete(int ID_Empleado)
        {
            Empleados oEmp = new Empleados();
            try
            {
                oEmp = lsEmpleados.FirstOrDefault(e => e.ID_Empleado == ID_Empleado);
                if (oEmp == null) oEmp = new Empleados();
                else lsEmpleados.Remove(oEmp);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

            }
            return View();
        }
    }
}
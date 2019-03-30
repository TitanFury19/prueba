using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practhelpe.Models;

namespace practhelpe.Controllers
{
    public class helper2Controller : Controller
    {
        // GET: helper2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult formulario()
        {
            return View();
        }
        public ActionResult datos()
        {
            if (ModelState.IsValid) 
            {
                Class1 c = new Class1();

                c.cedula = Request.Form["cedula"].ToString();
                c.nombre = Request.Form["nombre"].ToString();
                c.apellido = Request.Form["apellido"].ToString();
                c.edad = Convert.ToInt32(Request.Form["edad"].ToString());
                c.telefono = Request.Form["telefono"].ToString();
                c.correo = Request.Form["correo"].ToString();
                c.genero = Request.Form["genero"].ToString();
                c.estadoc = Request.Form["estadoc"].ToString();
                c.hobbys = (Request.Form["hobbys"].ToString());

                               

                return View(c);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportesPrueba01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            Session["nombreUsuario"] = "JOSE FLORES ALVARADO";
            Session["idUsuario"] = 1;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

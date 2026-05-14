using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroduccionC_.Models;

namespace IntroduccionC_.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET: Multiplicacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(Multiplicacion mul)
        {
            mul.CalcularMultiplicacion();
            return View(mul);
        }
    }
}

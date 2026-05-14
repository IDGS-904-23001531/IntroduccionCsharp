using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using IntroduccionC_.Models;

namespace IntroduccionC_.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(Distancia dis)
        {
            dis.CalcularDistancia();
            return View(dis);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVCPRUEBA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "HOLA MUNDO ME LA CHUPAN";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JuegosEroticos()
        {
            ViewBag.Message = "SEÑORA SU HIJO ESTA VIENDO PORNO";

            return View();
        }
    }
}
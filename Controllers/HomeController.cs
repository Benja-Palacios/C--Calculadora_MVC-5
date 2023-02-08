using EvaluacionCalculadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EvaluacionCalculadora.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Mensaje = "Resultados de las Operaciones Seleccionadas";

            ViewBag.Message = "Your application description page.";
            ViewBag.Sumatoria = TempData["suma"];
            ViewBag.Restatoria = TempData["resta"];
            ViewBag.Multitoria = TempData["multi"];
            ViewBag.Diviciontoria = TempData["divicion"];
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Calculadora() {
            
            return View();
        }
        [HttpPost]
        public ActionResult Calculadora(OperacionesBasicas operacionesBasicas)
        {
            if (operacionesBasicas.opSuma == true)
            {
                TempData["suma"] = operacionesBasicas.num1 + operacionesBasicas.num2;
            }
            if (operacionesBasicas.opResta == true)
            {
                TempData["resta"] = operacionesBasicas.num1 - operacionesBasicas.num2;
            }
            if (operacionesBasicas.opMulti == true)
            {
                TempData["multi"] = operacionesBasicas.num1 * operacionesBasicas.num2;
            }
            if (operacionesBasicas.opDivicion == true)
            {
                TempData["divicion"] = operacionesBasicas.num1 / operacionesBasicas.num2;
            }

            return RedirectToAction("About", "Home");
        }
    }
}
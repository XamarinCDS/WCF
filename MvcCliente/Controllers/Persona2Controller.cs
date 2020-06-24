using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCliente.Controllers
{
    public class Persona2Controller : Controller
    {
        // GET: Persona2
        public ActionResult Index()
        {
            SRPersona.SPersonasClient personas = new SRPersona.SPersonasClient();
            return View(personas.GetPersonas().ToList());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCliente.Controllers
{
    public class PersonasController : Controller
    {
        public ActionResult Index()
        {
            SRPersona.SPersonasClient personas = new SRPersona.SPersonasClient();
            return View(personas.GetPersonas().ToList());
        }
        public ActionResult Detalle(int id)
        {
            SRPersona.SPersonasClient persona = new SRPersona.SPersonasClient();
            return View(persona.GetPersona(id));
        }
    }
}
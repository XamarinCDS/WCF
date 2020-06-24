using System.Linq;
using System.Web.Mvc;

namespace MvcCliente.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            WSClientes.ClientesClient clientes = new WSClientes.ClientesClient();
            return View(clientes.GetClientes().ToList());
        }
        public ActionResult Detalle(int id)
        {
            WSClientes.ClientesClient cliente = new WSClientes.ClientesClient();
            return View(cliente.GetCliente(id));
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace GestorInventariosDestinoAPI.Controllers
{
    public class InventarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

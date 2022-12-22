using Microsoft.AspNetCore.Mvc;

namespace Escuela_asp.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

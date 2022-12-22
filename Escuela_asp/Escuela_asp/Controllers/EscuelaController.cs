using Escuela_asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_asp.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundación = 1971;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "ESTI No. 3";

            return View(escuela);
        }

    }
}

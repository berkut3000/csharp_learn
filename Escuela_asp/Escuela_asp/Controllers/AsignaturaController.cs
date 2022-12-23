using Escuela_asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_asp.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Matemáticas"
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.UtcNow;

            return View(asignatura);
        }

    }
}

using Escuela_asp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Escuela_asp.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 1971;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "ESTI No. 3";
            escuela.Ciudad = "Xalapa";
            escuela.Pais = "México";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Dirección = "Avila Camacho 502";

            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault;
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }

    }
}

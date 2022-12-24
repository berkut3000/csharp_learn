using Escuela_asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_asp.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura
            {
                Nombre = "Programacion",
                UniqueId = Guid.NewGuid().ToString()
            };

            return View(asignatura);
        }
        public IActionResult Multiasignatura()
        {
            var listaAsignaturas = new List<Asignatura>() {
            new Asignatura {
                    Nombre = "Matemáticas",
                    UniqueId = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Educación Física",
                    UniqueId = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Castellano",
                    UniqueId = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Ciencias Naturales",
                    UniqueId = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Programacion",
                    UniqueId = Guid.NewGuid ().ToString ()
                    }
            };


            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.UtcNow;

            return View("Multiasignatura",listaAsignaturas);
        }

    }
}

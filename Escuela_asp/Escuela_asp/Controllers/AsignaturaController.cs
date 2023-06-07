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
                Id = Guid.NewGuid().ToString()
            };
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.UtcNow;

            return View(asignatura);
        }
        public IActionResult Multiasignatura()
        {
            var listaAsignaturas = new List<Asignatura>() {
            new Asignatura {
                    Nombre = "Matemáticas",
                    Id = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Educación Física",
                    Id = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Castellano",
                    Id = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Ciencias Naturales",
                    Id = Guid.NewGuid ().ToString ()
                    },
                    new Asignatura {
                    Nombre = "Programacion",
                    Id = Guid.NewGuid ().ToString ()
                    }
            };


            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.UtcNow;

            return View("Multiasignatura",listaAsignaturas);
        }

    }
}

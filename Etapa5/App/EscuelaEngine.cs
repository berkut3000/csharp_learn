using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {


        }

        public void Inicializar()
        {
            Escuela = new Escuela("ESTI No.3", 1959);
            // escuela.Nombre = "ESTI No. 3";
            Escuela.Pais = "Mexico";
            Escuela.Ciudad = "Xalapa";
            Escuela.tiposEscuela = TiposEscuela.Secundaria;

            CargarCursos();
            CargarAsignaturas();            

            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            Random rnd = new Random();
            foreach ( var curso in Escuela.Cursos)
            {
                foreach(var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        float cNota = rnd.Next(0, 50);
                        if (cNota != 0)
                        {
                            cNota = cNota/10;
                        }
                        var eval = new Evaluación
                        {
                            Alumno = alumno,
                            Asignatura = asignatura,
                            Nota = cNota
                        };
                        alumno.EvaluacionesList.Add(eval);
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach(var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>() { 
                    new Asignatura{Nombre = "Matematicas"},
                    new Asignatura{Nombre = "Educacion Fisica"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"},
                    new Asignatura{Nombre = "Geografía"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private IEnumerable<Alumno> GenerarAlumnosAlAzar(int cantidadConsiderar)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                                from n2 in nombre2
                                    from a1 in apellido1
                                        select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy( (al) => al.UniqueId).Take(cantidadConsiderar);
        }


        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso() { Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde},
            };
            Random rnd = new Random();
            foreach(var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom).ToList();
            }
        }
    }
}

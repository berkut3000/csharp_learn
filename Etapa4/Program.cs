using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using System.Collections.Generic;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            
            Printer.WriteTitle("Bienvenidos a la Escuela");
            Printer.Beep(180,500, 2);

            ImprimirCursosEscuela(engine.Escuela);
        }

        private static bool predicado(Curso curso_obj)
        {
            return curso_obj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Lista de Cursos de la Escuela");
            foreach (Curso curso in escuela.Cursos)
            {
                WriteLine($"{curso.Nombre} , {curso.UniqueId}");
            }
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            foreach (Curso curso in arregloCursos)
            {
                Console.WriteLine($"{curso.Nombre} , {curso.UniqueId}");
            }
        }
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"{arregloCursos[contador].Nombre} , {arregloCursos[contador].UniqueId}");
            }
            while (++contador < arregloCursos.Length);
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int contador = 0; contador < arregloCursos.Length; contador++)
            {
                Console.WriteLine($"{arregloCursos[contador].Nombre} , {arregloCursos[contador].UniqueId}");
            }
        }
    }
}

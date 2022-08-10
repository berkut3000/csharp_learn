using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("ESTI No.3", 1959);
            // escuela.Nombre = "ESTI No. 3";
            escuela.Pais = "Mexico";
            escuela.Ciudad = "Xalapa";
            escuela.tiposEscuela = TiposEscuela.Secundaria;

            escuela.Cursos = new List<Curso>()
            {
                new Curso(){ Nombre = "101" },
                new Curso(){ Nombre = "201" },
                new Curso(){ Nombre = "301" },
            };

            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Mañana });
            escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Mañana });

            var otra_coleccion = new List<Curso>{
                new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana},
                new Curso() { Nombre = "402", Jornada = TiposJornada.Mañana},
                new Curso() { Nombre = "403", Jornada = TiposJornada.Tarde},
            };

            otra_coleccion.Clear();
            //escuela.Cursos.Remove();
            escuela.Cursos.AddRange(otra_coleccion);



            /*            escuela.Cursos = new Curso[]{ 
                        //Curso[] arregloCursos = {
                            new Curso(){ Nombre = "101" },
                            new Curso(){ Nombre = "201" },
                            new Curso(){ Nombre = "301" },
                        };*/
            //arregloCursos[0] = new Curso()
            //                        {
            //                            Nombre = "101"
            //                        };

            //arregloCursos[1] = new Curso()
            //{
            //    Nombre = "201"
            //};

            //arregloCursos[2] = new Curso()
            //{
            //    Nombre = "301"
            //};

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine(escuela.Nombre + " " + escuela.añoCreacion);
            Console.WriteLine(escuela);
            Console.WriteLine("============");
            //Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            //Console.WriteLine(curso2.Nombre + "," + curso2.UniqueId);
            //Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");
            //foreach (Curso curso in arregloCursos)
            //{
            //    Console.WriteLine($"{curso.Nombre} , {curso.UniqueId}");
            //}
            //ImprimirCursosFor(arregloCursos);
            //escuela = null;
            //escuela.Cursos = null;
            //if (escuela != null && escuela.Cursos != null)
            //{
            //    ImprimirCursosEscuela(escuela);
            //}
            if (escuela?.Cursos != null)
            {
                ImprimirCursosEscuela(escuela);
            }

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("==========================");
            WriteLine("Lista de Cursos Escuela");
            WriteLine("==========================");
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

using System;
using CoreEscuela.Entidades;

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
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine(escuela.Nombre + " " + escuela.añoCreacion);
            Console.WriteLine(escuela);
        }
    }
}

using System;

namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Este programa calcula el area de un rectangulo
             * Rectangle area calculation */
            Console.WriteLine("Ingrese el ladoA:");
            float sideA = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ladoB:");
            float sideB = float.Parse(Console.ReadLine());
            //int sideB = 20;
            /*int sideB = 1;
            sideB++;
            sideB++;
            sideB++;
            sideB++;
            sideB++;*/
            float product = (sideA * sideB);
            //rectangle values formula is a*b
            Console.WriteLine("The rectangle are is: " + product);

        }
    }
}

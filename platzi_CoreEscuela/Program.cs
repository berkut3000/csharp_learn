using System;

namespace CoreEscuela
{   
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;

        public void timbrar()
        {
            Console.Beep(200,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Escuela miEscuela = new Escuela();
            miEscuela.nombre = "ESTI No. 3";
            miEscuela.direccion = "Avila Camacho No. 120";
            miEscuela.añoFundacion = 1980;

            Console.WriteLine("La escuela " + miEscuela.nombre + " se encuentra en " + miEscuela.direccion + " y fué fundada en " + miEscuela.añoFundacion + ".");
            Console.WriteLine("Es hora de ingresar!"    );
            miEscuela.timbrar();
        }
    }
}
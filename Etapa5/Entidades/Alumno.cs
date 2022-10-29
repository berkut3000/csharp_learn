using System;
namespace CoreEscuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> EvaluacionesList { get; set; }

        public Alumno()=> (EvaluacionesList) = (new List<Evaluación>());
    }
}

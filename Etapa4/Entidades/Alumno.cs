using System;
namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public List<Evaluaciones> EvaluacionesList { get; set; }

        public Alumno()=> (UniqueId,EvaluacionesList) = ((Guid.NewGuid().ToString()), new List<Evaluaciones>());
    }
}

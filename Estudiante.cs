using System;

namespace poo_tarea_
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public int Matricula {get; set;}
        public string Carrera { get; set;}

        public static void TomarClases(Estudiante estudiante)
        {
            Console.WriteLine($"{estudiante.Nombre} está tomando clases");
        }
    }
}

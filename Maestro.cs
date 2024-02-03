using System;

namespace poo_tarea_
{
    public class Maestro : Docente
    {
        public string NivelEducativo { get; set; }
        public int Experiencia { get; set; }

        public static void DarClase(Maestro maestro)
        {
            Console.WriteLine($"{maestro.Nombre} está dando clases de {maestro.Materia}");
        }
    }
}

using System;


namespace poo_tarea_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Gean Carlos Valera",
                Edad = 21,
                Matricula = 2022,
                Carrera = "Desarrollo de software"
            };

            Maestro maestro1 = new Maestro
            {
                Nombre = "Great Onizuka",
                Edad = 32,
                Cargo = "Profesor",
                Materia = "Proyecto de vida",
                NivelEducativo = "Secundaria",
                Experiencia = 2
            };

            Maestro.DarClase(maestro1);

            Estudiante.TomarClases(estudiante1);
        }
    }
}

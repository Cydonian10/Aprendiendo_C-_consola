// See https://aka.ms/new-console-template for more information
using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();

            engine.Inicializar();

            Printer.EscribirTitulo("Bienvenidos a mi escuela");

            WriteLine(engine.Escuela);

            Printer.EscribirTitulo("Cursos");

            printCursos(engine.Escuela);

        }

        // private static bool RemoveByName(Curso curso)
        // {
        //     return curso.Nombre == "101";
        // }

        private static void printCursos(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"{curso.Id} ==> {curso.Nombre}");
                }
            }
        }
    }
}

using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea = "".PadLeft(tam, '=');
            WriteLine(linea);
        }

        public static void EscribirTitulo(string titulo)
        {
            WriteLine("\n");
            DibujarLinea(titulo.Length + 4);
            WriteLine($"| {titulo} |");
            DibujarLinea(titulo.Length + 4);
            WriteLine("\n");
        }
    }
}
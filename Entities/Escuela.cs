//using System.Collections.Generic;
namespace CoreEscuela.Entidades

{
    public class Escuela
    {
        private string nombre = "";
        public string Nombre { get { return "Copia: " + nombre; } set { nombre = value.ToUpper(); } }

        public int AñoDeCreacion { get; set; }

        public string? Pais { get; set; }

        public string? Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso>? Cursos { get; set; }

        //contructor
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public Escuela(
            string nombre,
            int año,
            string pais = "",
            string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{nombre}\" \nAño de Creacion: {AñoDeCreacion} \nPais: {Pais} \nCiudad: {Ciudad}";
        }
    }
}

namespace CoreEscuela.Entidades
{

    public class Evaluacion
    {
        public string Id { get; set; }

        public string? Name { get; set; }

        public float? Nota { get; set; }

        public Alumno? Alumno { get; set; }

        public Asignatura? Asignatura { get; set; }

        public Evaluacion()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
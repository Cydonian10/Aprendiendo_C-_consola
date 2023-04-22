namespace CoreEscuela.Entidades
{

    public class Alumno
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }

        public Alumno(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Evaluaciones = new List<Evaluacion> { };
        }
    }
}
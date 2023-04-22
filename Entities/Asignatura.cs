namespace CoreEscuela.Entidades
{

    public class Asignatura
    {
        public string Id { get; set; }

        public string? Name { get; set; }

        public Asignatura()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
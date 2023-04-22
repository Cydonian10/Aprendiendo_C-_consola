using CoreEscuela.Entidades;
//using System.Collections.Generic;
using System.Linq;

namespace CoreEscuela
{
    class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {
            Escuela = new Escuela("PlatziAcademi", 2020, pais: "Peru", ciudad: "Lima");
        }

        public void Inicializar()
        {
            CargarCursos();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso> {
                new Curso()
                {
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana
                },
                new Curso()
                {
                    Nombre = "102",
                    Jornada = TiposJornada.Mañana
                },
                new Curso()
                {
                    Nombre = "103",
                    Jornada = TiposJornada.Mañana
                }
            };

            CargarAsignatura();
            CargarAlumnos();
            CargarEvaluaciones();
        }

        private void CargarAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>() {
                new Asignatura() { Name = "Educacion fsica" },
                new Asignatura() { Name = "Matematicas" },
                new Asignatura() { Name = "Comunicacion" },
                new Asignatura() { Name = "Fisica" },
            };

            if (Escuela.Cursos != null)
            {
                foreach (var curso in Escuela.Cursos)
                {
                    curso.Asignaturas = listaAsignaturas;
                }
            }
        }

        private void CargarAlumnos()
        {
            if (Escuela.Cursos != null)
            {
                foreach (var curso in Escuela.Cursos)
                {
                    var randomCantidad = new Random().Next(1, 10);
                    curso.Alumnos = GenerarAlumnos(randomCantidad);
                }
            }
        }

        private void CargarEvaluaciones()
        {
            if (Escuela.Cursos != null)
            {
                foreach (var curso in Escuela.Cursos)
                {
                    foreach (var asignatura in curso.Asignaturas!)
                    {
                        foreach (var alumno in curso.Alumnos!)
                        {
                            var rnd = new Random(System.Environment.TickCount);
                            for (int i = 0; i < 5; i++)
                            {
                                var ev = new Evaluacion()
                                {
                                    Asignatura = asignatura,
                                    Name = $"{asignatura.Name} - Eval${i + 1}",
                                    Alumno = alumno,
                                    Nota = (float)(5 * rnd.NextDouble())
                                };

                                alumno.Evaluaciones.Add(ev);
                            }
                        }
                    }
                }
            }

        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var alumnos = from n1 in nombre1
                          from n2 in nombre2
                          from n3 in apellido1
                          select new Alumno($"{n1} {n2} {n3}");

            return alumnos.OrderBy(al => al.Id).Take(cantidad).ToList();
        }
    }
}
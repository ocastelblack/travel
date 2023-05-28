namespace travel.Models
{
    public class Libro
    {
        public int ISBN { get; set; }
        public int EditorialesId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string NPaginas { get; set; }

        public Editorial Editorial { get; set; }
    }

    public class Editorial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sede { get; set; }
    }

    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public List<Libro> Libros { get; set; }
    }
}

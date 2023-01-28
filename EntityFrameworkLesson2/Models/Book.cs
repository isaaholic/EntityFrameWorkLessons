namespace EntityFrameworkLesson2.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }

        public T_Card T_Card { get; set; }
        public S_Card S_Card { get; set; }

        public int ThemesId { get; set; }
        public Theme Themes { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PressId { get; set; }
        public Press Press { get; set; }
    }
}

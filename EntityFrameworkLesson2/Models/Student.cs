namespace EntityFrameworkLesson2.Models
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int S_CardId { get; set; }
        public S_Card S_Card { get; set; }

        public int Term { get; set; }
    }
}
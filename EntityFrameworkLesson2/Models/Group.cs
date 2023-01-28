namespace EntityFrameworkLesson2.Models
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

    }
}
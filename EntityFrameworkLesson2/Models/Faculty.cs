namespace EntityFrameworkLesson2.Models
{
    public class Faculty:BaseEntity
    {
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}
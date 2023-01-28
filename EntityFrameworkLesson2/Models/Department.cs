namespace EntityFrameworkLesson2.Models
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
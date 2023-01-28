namespace EntityFrameworkLesson2.Models
{
    public class Teacher:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int T_CardId { get; set; }
        public T_Card T_Card { get; set; }
    }
}
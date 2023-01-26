namespace EntityFrameWorkLesson.Models;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitInStock { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public List<Order> Orders { get; set; }
}

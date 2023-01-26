using EntityFrameWorkLesson.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkLesson.Models;

public class AppUser:BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    [NotMapped]
    public string RePassword { get; set; }
    public Roles Role { get; set; }

    public AppUserDetail AppUserDetail { get; set; }
    public List<Order> Orders { get; set; }
}

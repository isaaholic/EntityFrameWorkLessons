using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkLesson.Models
{
    public class AppUserDetail:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}

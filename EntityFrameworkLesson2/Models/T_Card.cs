using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLesson2.Models
{
    public class T_Card:BaseEntity
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public Teacher Teacher { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int LibId { get; set; }
        public Lib Lib { get; set; }
    }
}

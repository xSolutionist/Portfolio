using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Heading { get; set; }
        public string SubHeading { get; set; }
        public string Article { get; set; }
    }
}

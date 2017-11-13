using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsBlog.Models.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string ShortDiscription { get; set; }
        public string Description { get; set; }
        public byte [] Image { get; set; }
    }
}

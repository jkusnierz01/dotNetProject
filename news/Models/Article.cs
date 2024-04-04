using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace news.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Topic { get; set; }
        public string Author { get; set; }
        public string DateOfPublish { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

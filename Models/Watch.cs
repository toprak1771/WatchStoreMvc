using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStoreMvcDeneme.Models
{
    public class Watch
    {
        public Watch()
        {
            comments = new List<Comment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string color { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }
        public List<Comment> comments { get; set; }
    }
}

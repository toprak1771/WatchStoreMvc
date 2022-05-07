using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStoreMvcDeneme.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Watch Watch { get; set; }

    }
}

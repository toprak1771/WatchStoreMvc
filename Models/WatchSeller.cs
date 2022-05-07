using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStoreMvcDeneme.Models
{
    public class WatchSeller
    {
        public int Id { get; set; }
        public Watch Watch { get; set; }
        public Seller Seller { get; set; }
    }
}

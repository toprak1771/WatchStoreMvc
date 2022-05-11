using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchStoreMvcDeneme.Models;

namespace WatchStoreMvcDeneme.ViewModel
{
    public class SellerWatchViewModel
    {
        public Watch watch { get; set; }
        public List<Watch> watches { get; set; }
        public Seller seller { get; set; }
        public List<Seller> sellers { get; set; }
        public List<int> SellerIds { get; set; }

    }
}

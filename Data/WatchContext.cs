using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchStoreMvcDeneme.Models;

namespace WatchStoreMvcDeneme.Data
{
    public class WatchContext:DbContext 
    {
        public WatchContext(DbContextOptions<WatchContext> options):base(options) 
        {
            
        }
        public DbSet<Watch> Watches { get; set; }
        public DbSet<Comment> Comments {get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<WatchSeller> WatchSellers { get; set; }
        
    }
}

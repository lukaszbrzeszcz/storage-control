using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class ProgramContext : DbContext
    {
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Distance> Distances { get; set; }
    }
}

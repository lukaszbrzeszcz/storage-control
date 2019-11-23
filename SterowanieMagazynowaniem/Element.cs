using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class Element
    {
        public int ElementId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int SectorID { get; set; }
        public virtual Sector Sector { get; set; }
    }
}

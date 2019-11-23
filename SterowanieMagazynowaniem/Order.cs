using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual List<Element> Elements { get; set; }
    }
}

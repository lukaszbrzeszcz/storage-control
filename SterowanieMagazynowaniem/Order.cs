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
        public virtual List<Medicine> Medicines { get; set; }

        public decimal Price()
        {
            decimal sum = 0;
            foreach (Medicine med in Medicines)
            {
                sum += med.Price;
            }
            return sum;
        }

        public override string ToString()
        {
            return string.Format("Order {0}", OrderId);
        }
    }
}

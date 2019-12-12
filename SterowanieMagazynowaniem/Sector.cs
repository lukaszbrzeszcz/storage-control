using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class Sector
    {
        public int SectorId { get; set; }
        public string Name { get; set; }

        public virtual List<Medicine> Medicines { get; set; }

        public virtual List<Distance> DistancesTo { get; set; }
        public virtual List<Distance> DistancesFrom { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}

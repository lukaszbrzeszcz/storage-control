using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class Distance
    {
        public int DistanceId { get; set; }

        public int SectorFromId { get; set; }
        public virtual Sector SectorFrom { get; set; }

        public int SectorToId { get; set; }
        public virtual Sector SectorTo { get; set; }
    }
}

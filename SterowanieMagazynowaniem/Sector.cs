﻿using System;
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

        public virtual List<Element> Elements { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: {1}", SectorId, Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class Distance
    {
        public int DistanceId { get; set; }

        [Index("IX_FromAndTo", 1, IsUnique =true)]
        public int SectorFromId { get; set; }
        public virtual Sector SectorFrom { get; set; }

        [Index("IX_FromAndTo", 2, IsUnique = true)]
        public int SectorToId { get; set; }
        public virtual Sector SectorTo { get; set; }

        public int Value { get; set; }


        public static void AddDistance(Sector from, Sector to, int val)
        {
            using (var db = new ProgramContext())
            {
                Sector from_s = db.Sectors.Find(from.SectorId);
                Sector to_s = db.Sectors.Find(to.SectorId);
                Distance dist = new Distance
                {
                    SectorFrom = from_s,
                    SectorFromId = from_s.SectorId,
                    SectorTo = to_s,
                    SectorToId = to_s.SectorId,
                    Value = val
                };
                from_s.DistancesFrom.Add(dist);
                to_s.DistancesTo.Add(dist);
                db.Distances.Add(dist);
                db.SaveChanges();
            }
        }

        public override string ToString()
        {
            return String.Format("From: {0}, To: {1} - distance: {2}", SectorFrom.Name, SectorTo.Name, Value);
        }
    }
}

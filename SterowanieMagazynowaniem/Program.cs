using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SterowanieMagazynowaniem
{
    static class Program
    {
        public static Random rand = new Random();
        public static Dijkstra d;
        public static int sec_0_id;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            d = GetDijkstra();
            var db = new ProgramContext();
            sec_0_id = db.Sectors.Where(sec => sec.Name == "0").First().SectorId;
            Application.Run(new Form1());         
        }

        public static Dijkstra GetDijkstra()
        {
            List<Sector> sectors;
            List<Distance> distances;
            using (var db = new ProgramContext())
            {
                sectors = db.Sectors.ToList();
                distances = db.Distances.ToList();
            }
            Dijkstra d = new Dijkstra(sectors, distances);
            return d;
        }
    }
}

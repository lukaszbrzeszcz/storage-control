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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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

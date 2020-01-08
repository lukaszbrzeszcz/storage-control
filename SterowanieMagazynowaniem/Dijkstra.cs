using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class Dijkstra
    {
        public Dictionary<int, Dictionary<int, int>> graph;

        public Dijkstra(List<Sector> sectors, List<Distance> distances)
        {
            graph = new Dictionary<int, Dictionary<int, int>>();
            foreach ( var s1 in sectors )
            {
                foreach ( var s2 in sectors )
                {
                    int val;
                    if (s1.SectorId == s2.SectorId)
                        val = 0;
                    else
                        val = int.MaxValue;

                    if (!graph.ContainsKey(s1.SectorId))
                        graph[s1.SectorId] = new Dictionary<int, int>();
                    graph[s1.SectorId][s2.SectorId] = val;
                }
            }

            
            
            foreach (var s1 in sectors)
            {
                List<int> L = new List<int>();
                foreach (var s in sectors) L.Add(s.SectorId);
                for (int i = 1; i <= sectors.Count; i++)
                {
                    int min = int.MaxValue;
                    int min_id = -1;
                    foreach (var s2 in sectors)
                    {
                        if (!L.Contains(s2.SectorId)) continue;
                        if (graph[s1.SectorId][s2.SectorId] < min)
                        {
                            min = graph[s1.SectorId][s2.SectorId];
                            min_id = s2.SectorId;
                        }
                    }
                    L.Remove(min_id);

                    foreach (var e in distances)
                    {
                        if (e.SectorFrom.SectorId == min_id)
                        {
                            if (graph[s1.SectorId][e.SectorTo.SectorId] > graph[s1.SectorId][e.SectorFrom.SectorId] + e.Value)
                            {
                                graph[s1.SectorId][e.SectorTo.SectorId] = graph[s1.SectorId][e.SectorFrom.SectorId] + e.Value;
                            }
                        }
                    }
                }
                
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach(KeyValuePair<int, Dictionary<int, int>> key_val_p in graph)
            {
                foreach(KeyValuePair<int, int> kvp in key_val_p.Value)
                {
                    str += string.Format("{0} -> {1}: {2}\n", key_val_p.Key, kvp.Key, kvp.Value);
                }
                str += "\n";
                
            }
            return str;
        }
    }

}

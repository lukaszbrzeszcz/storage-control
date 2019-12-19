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
        public Dictionary<string, Dictionary<string, int>> graph;

        public Dijkstra(List<Sector> sectors, List<Distance> distances)
        {
            graph = new Dictionary<string, Dictionary<string, int>>();
            foreach ( var s1 in sectors )
            {
                foreach ( var s2 in sectors )
                {
                    int val;
                    if (s1.Name == s2.Name)
                        val = 0;
                    else
                        val = int.MaxValue;

                    if (!graph.ContainsKey(s1.Name))
                        graph[s1.Name] = new Dictionary<string, int>();
                    graph[s1.Name][s2.Name] = val;
                }
            }

            
            
            foreach (var s1 in sectors)
            {
                List<string> L = new List<string>();
                foreach (var s in sectors) L.Add(s.Name);
                for (int i = 1; i <= sectors.Count; i++)
                {
                    int min = int.MaxValue;
                    string min_name = "";
                    foreach (var s2 in sectors)
                    {
                        if (!L.Contains(s2.Name)) continue;
                        if (graph[s1.Name][s2.Name] < min)
                        {
                            min = graph[s1.Name][s2.Name];
                            min_name = s2.Name;
                        }
                    }
                    L.Remove(min_name);

                    foreach (var e in distances)
                    {
                        if (e.SectorFrom.Name == min_name)
                        {
                            if (graph[s1.Name][e.SectorTo.Name] > graph[s1.Name][e.SectorFrom.Name] + e.Value)
                            {
                                graph[s1.Name][e.SectorTo.Name] = graph[s1.Name][e.SectorFrom.Name] + e.Value;
                            }
                        }
                    }
                }
                
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach(KeyValuePair<string, Dictionary<string, int>> key_val_p in graph)
            {
                foreach(KeyValuePair<string, int> kvp in key_val_p.Value)
                {
                    str += string.Format("{0} -> {1}: {2}\n", key_val_p.Key, kvp.Key, kvp.Value);
                }
                str += "\n";
                
            }
            return str;
        }
    }

}

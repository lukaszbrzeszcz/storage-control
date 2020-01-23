using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class SA
    {
        public static float T0_def = 25F;
        public static float Tk_def = 0.05F;
        public static float lambda_def = 0.9999F;

        public int NWorkers { get; set; }
        public int ItemLimit { get; set; }
        public List<Medicine> Medicines { get; set; }
        public int GoalFunction { get; set; }
        public string TextOutput;
        public List<int> x;
        public List<int> y;
        public bool finished = false;
        public float T0;
        public float Tk;
        public float lambda;


        public SA(int num_of_workers, int item_limit, List<Medicine> medicines, float T0, float Tk, float lambda)
        {
            NWorkers = num_of_workers; ItemLimit = item_limit; Medicines = medicines; this.T0 = T0; this.Tk = Tk; this.lambda = lambda;
            Medicines.Insert(0, null);
            Medicines.Add(null);
            Random rand = new Random();
            for(int i=1; i<NWorkers; i++)
            {
                if (i * item_limit < Medicines.Count)
                    Medicines.Insert(i * item_limit, null);
                else
                    Medicines.Add(null);
                //Medicines.Insert(rand.Next(Medicines.Count - 1) + 1, null); /////////////TUTAJ
            }

            foreach (var med in Medicines)
            {
                //Debug.WriteLine(med);
            }
            var db = new ProgramContext();
            TextOutput = "";
            x = new List<int>();
            y = new List<int>();
            finished = false;
        }

        public int Goal(List<Medicine> perm)
        {
            int max_dist = 0;
            int counter = 0;
            int curr_dist = 0;
            for(int i=0; i<perm.Count-1; i++)
            {
                counter++;
                if(counter > ItemLimit)
                {
                    max_dist = -1;
                    break;
                }
                int from_id, to_id;
                Medicine from = perm[i];
                Medicine to = perm[i + 1];
                from_id = from != null ? from.SectorID : Program.sec_0_id;
                to_id = to != null ? to.SectorID : Program.sec_0_id;
                curr_dist += Program.d.graph[from_id][to_id];
                if(to == null)
                {
                    max_dist = Math.Max(curr_dist, max_dist);
                    curr_dist = 0;
                    counter = 0;
                }
            }
            return max_dist;
        }

        public Tuple<List<Medicine>, int> GetNewPerm(List<Medicine> perm, bool isInitial)
        {
            List<Medicine> new_perm = new List<Medicine>(perm);
            int perm_len = new_perm.Count - 1;
            int a, b;
            int goal = int.MaxValue;
            bool found = false;
            while (!found)
            {
                if(!isInitial)
                {
                    new_perm = new List<Medicine>(perm);
                }           
                a = Program.rand.Next(perm_len-1) + 1;
                b = Program.rand.Next(perm_len-1) + 1;
                Swap<Medicine>(new_perm, a, b);
                goal = Goal(new_perm);
                if(goal >= 0)
                    found = true;
            }
            return Tuple.Create(new_perm, goal);
        }


        public void Run()
        {
            var resp = GetNewPerm(Medicines, true);
            List<Medicine> current_perm = new List<Medicine>(resp.Item1);
            List<Medicine> best_perm = new List<Medicine>(resp.Item1);
            List<Medicine> new_perm;
            int best_goal = Goal(best_perm);
            int current_goal = best_goal;
            int new_goal;
            float T = T0;
            int counter = 0;
            while(T >= Tk)
            {
                counter++;
                resp = GetNewPerm(current_perm, false);
                new_perm = resp.Item1;
                new_goal = resp.Item2;
                if (new_goal < best_goal)
                {
                    best_perm = new_perm;
                    best_goal = new_goal;
                }
                if (new_goal <= current_goal)
                {
                    current_perm = new_perm;
                    current_goal = new_goal;
                }                 
                else
                {
                    int delta = new_goal - current_goal;
                    double prob = Math.Exp(-delta / T);
                    double z = Program.rand.NextDouble();
                    if (z <= prob)
                    {
                        current_perm = new_perm;
                        current_goal = new_goal;
                    }
                }
                T = lambda * T;
                x.Add(counter);
                y.Add(current_goal);
                //Debug.WriteLine("T = " + T.ToString() + ", Tk = " + Tk.ToString() + ", goal: " + current_goal.ToString());
            }
            finished = true;
            GoalFunction = best_goal;
            TextOutput += "Best Goal: " + Environment.NewLine;
            TextOutput += best_goal.ToString();
            TextOutput += Environment.NewLine + "Sectors order:" + Environment.NewLine;
            //Debug.WriteLine(best_goal);

            foreach(Medicine med in best_perm)
            {
                if(med != null)
                {
                    //Debug.Write(String.Format("{0} ", med.SectorID.ToString()));
                    TextOutput += String.Format("{0} ", med.SectorID.ToString());
                }
                else
                {
                    //Debug.Write("| ");
                    TextOutput += "| ";
                }            
            }
            
     
        }

        public static void Swap<T>(IList<T> list, int a, int b)
        {
            T tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }
    }
}

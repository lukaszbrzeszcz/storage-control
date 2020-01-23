using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SterowanieMagazynowaniem
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        private SA algo;
        public Form1()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
            Medicine.LoadMedicines();
            t0.Value = (decimal)SA.T0_def;
            tk.Value = (decimal)SA.Tk_def;
            lambd.Value = (decimal)SA.lambda_def;

        }

        private void Chart_Load(int[] x, int[] y)
        {
            line_chart.Series[0].ChartType = SeriesChartType.Line;
            line_chart.Series[0].Points.DataBindXY(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadSectorsList();
            ReloadDistancesList();
            ReloadSectorsFormsLists();
            ReloadOrdersList();
            var db = new ProgramContext();
            db.Medicines.Load();
            medicineBindingSource.DataSource = db.Medicines.Local.ToList();             
        }

        private void ReloadOrdersList()
        {
            BindingList<Order> orders = new BindingList<Order>();
            using (var db = new ProgramContext())
            {
                foreach(var o in db.Orders)
                {
                    orders.Add(o);
                }
                ordersListBox.DataSource = orders;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sector obj = (Sector)listBox1.SelectedItem;
            using (var db = new ProgramContext())
            {
                Sector sec = (from s in db.Sectors
                              where s.SectorId == obj.SectorId
                              select s).FirstOrDefault();
                db.Sectors.Remove(sec);
                db.SaveChanges();
            }
            ReloadSectorsList();
        }

        private void ReloadSectorsList()
        {
            BindingList<Sector> sectors = new BindingList<Sector>();
            using (var db = new ProgramContext())
            {
                foreach (var s in db.Sectors)
                {
                    sectors.Add(s);
                }
                listBox1.DataSource = sectors;
            }

        }

        private void ReloadDistancesList()
        {
            Sector sec = (Sector)listBox1.SelectedItem;
            if (sec == null)
            {
                return;
            }
            BindingList<Distance> from_distances = new BindingList<Distance>();
            BindingList<Distance> to_distances = new BindingList<Distance>();

            using (var db = new ProgramContext())
            {
                var s = db.Sectors.Find(sec.SectorId);
                var dists_from = s.DistancesFrom;
                foreach (var d in dists_from)
                {
                    from_distances.Add(d);
                }
                list_from_distances.DataSource = from_distances;
                var dists_to = s.DistancesTo;
                foreach (var d in dists_to)
                {
                    to_distances.Add(d);
                }
                list_to_distances.DataSource = to_distances;
            }

        }

        private void ReloadSectorsFormsLists()
        {
            BindingList<Sector> from_sectors = new BindingList<Sector>();
            BindingList<Sector> to_sectors = new BindingList<Sector>();
            using (var db = new ProgramContext())
            {
                foreach ( var s in db.Sectors)
                {
                    from_sectors.Add(s);
                    to_sectors.Add(s);
                }
            }
            comboBox_from.DataSource = from_sectors;
            comboBox_to.DataSource = to_sectors;
        }

        private void btn_add_sector_Click(object sender, EventArgs e)
        {
            string name = tb_new_sector_name.Text;
            Sector s = new Sector { Name = name };
            using (var db = new ProgramContext())
            {
                db.Sectors.Add(s);
                db.SaveChanges();
            }
            ReloadSectorsList();
            ReloadSectorsFormsLists();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadDistancesList();
        }

        private void btn_add_from_distance_Click(object sender, EventArgs e)
        {
            Sector to = (Sector)listBox1.SelectedItem;
            Sector from = (Sector)comboBox_from.SelectedItem;
            string val = value_from.Text;
            int value = int.Parse(val);
            Distance.AddDistance(from, to, value);
            ReloadSectorsFormsLists();
            ReloadDistancesList();
        }

        private void btn_add_to_distance_Click(object sender, EventArgs e)
        {
            Sector from = (Sector)listBox1.SelectedItem;
            Sector to = (Sector)comboBox_to.SelectedItem;
            string val = value_to.Text;
            int value = int.Parse(val);
            Distance.AddDistance(from, to, value);
            ReloadSectorsFormsLists();
            ReloadDistancesList();
        }

        private void remove_dist_from_Click(object sender, EventArgs e)
        {
            Distance obj = (Distance)list_from_distances.SelectedItem;
            using (var db = new ProgramContext())
            {
                Distance dist = (from d in db.Distances
                              where d.DistanceId == obj.DistanceId
                              select d).FirstOrDefault();
                db.Distances.Remove(dist);
                db.SaveChanges();
            }
            ReloadSectorsList();
            ReloadDistancesList();
        }

        private void remove_dist_to_Click(object sender, EventArgs e)
        {
            Distance obj = (Distance)list_to_distances.SelectedItem;
            using (var db = new ProgramContext())
            {
                Distance dist = (from d in db.Distances
                                 where d.DistanceId == obj.DistanceId
                                 select d).FirstOrDefault();
                db.Distances.Remove(dist);
                db.SaveChanges();
            }
            ReloadSectorsList();
            ReloadDistancesList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ordersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<Medicine> medicines = new BindingList<Medicine>();
            Order ord = (Order)ordersListBox.SelectedItem;
            using (var db = new ProgramContext())
            {
                foreach(var med in db.Orders.Where(o => o.OrderId == ord.OrderId).First().Medicines.ToList())
                {
                    medicines.Add(med);
                }
            }
            medicinesListBox.DataSource = medicines;
        }

        private void generateOrderBtn_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            Random rand = new Random();
            using (var db = new ProgramContext())
            {
                List<Medicine> medicines = db.Medicines.OrderBy(r => Guid.NewGuid()).Take(rand.Next(20)).ToList();
                ord.Medicines = medicines;
                db.Orders.Add(ord);
                db.SaveChanges();
            }
            ReloadOrdersList();
        }

        private void removeOrderBtn_Click(object sender, EventArgs e)
        {
            Order ord = (Order)ordersListBox.SelectedItem;
            using (var db = new ProgramContext())
            {
                Order to_del = db.Orders.Where(o => o.OrderId == ord.OrderId).First();
                db.Orders.Remove(to_del);
                db.SaveChanges();
            }
            ReloadOrdersList();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {       
            ProcessAlgo();
        }

        private void ProcessAlgo()
        {
            updateText("Processing...");
            Task.Factory.StartNew(() => RunAlgo()).ContinueWith((n) => this.Invoke((MethodInvoker)delegate { PrintOutput(); }));
        }

        private void PrintOutput()
        {      
            String txt = "Algorithm cannot run for current workers count and medicines limit.";
            if (algo != null && algo.finished)
            {
                int[] x = algo.x.ToArray();
                int[] y = algo.y.ToArray();
                Chart_Load(x, y);
                txt = algo.TextOutput;
                algo.finished = false;
            }
            updateText(txt);
        }

        private void updateText(String txt)
        {
            textBoxOutput.Text = txt;
        }
        private void RunAlgo()
        {
            var db = new ProgramContext();
            List<Medicine> medicines = new List<Medicine>();
            foreach (Order ord in db.Orders.ToList())
            {
                medicines.AddRange(ord.Medicines);
            }
            int numWorkers = (int)nWorkers.Value;
            int limitMedicines = (int)limit.Value;
            float T0 = (float)t0.Value;
            float Tk = (float)tk.Value;
            float Lambda = (float)lambd.Value;
            if (numWorkers * limitMedicines < medicines.Count)
            {
                return;
            }
            algo = new SA(numWorkers, limitMedicines, medicines, T0, Tk, Lambda);
            algo.Run();        

            
        }
    }
}

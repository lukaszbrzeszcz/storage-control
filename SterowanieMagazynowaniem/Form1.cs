using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SterowanieMagazynowaniem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadSectorsList();
            ReloadDistancesList();
            ReloadSectorsFormsLists();
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
        }

        private void btn_add_to_distance_Click(object sender, EventArgs e)
        {
            Sector from = (Sector)listBox1.SelectedItem;
            Sector to = (Sector)comboBox_to.SelectedItem;
            string val = value_to.Text;
            int value = int.Parse(val);
            Distance.AddDistance(from, to, value);
            ReloadSectorsFormsLists();
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
        }
    }
}

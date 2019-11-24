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
            using (var db = new ProgramContext())
            {
                BindingList<Sector> sectors = new BindingList<Sector>();
                foreach (var s in db.Sectors)
                {
                    sectors.Add(s);
                }
                listBox1.DataSource = sectors;
            }

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
        }
    }
}

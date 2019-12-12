using EntityFramework.BulkInsert.Extensions;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int SectorID { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual List<Order> Orders { get; set; }

        public Medicine()
        {
            Name = "";
            Price = 0;
        }

        public Medicine(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            Sector sec;
            string str;
            using (var db = new ProgramContext())
            {
                sec = db.Sectors.Where(s => s.SectorId == SectorID).First();
                str = string.Format("{0}, {1}, {2}", Name, Price, sec.Name);
            }
            return str;
        }

        internal static void LoadMedicines()
        {
            using (var db = new ProgramContext())
            {
                var medicines = db.Medicines.ToList();
                if (medicines.Count == 0)
                {
                    LoadMedicines_();
                }
            }
        }

        private static void LoadMedicines_()
        {
            using (TextFieldParser parser = new TextFieldParser(Path.Combine(Environment.CurrentDirectory, "output.csv")))
            {
                using (var db = new ProgramContext())
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    List<Sector> sectors = db.Sectors.ToList();
                    IList<Medicine> medicines = new List<Medicine>();
                    Random rand = new Random();
                    while (!parser.EndOfData)
                    {
                        string name;
                        decimal price;
                        string[] fields = parser.ReadFields();
                        name = fields[0];
                        price = decimal.Parse(fields[1], NumberStyles.AllowDecimalPoint | NumberStyles.Float, new CultureInfo("en-GB"));
                        Medicine med = new Medicine(name, price);
                        Sector sec = sectors[rand.Next(sectors.Count)];
                        med.Sector = sec;
                        med.SectorID = sec.SectorId;
                        medicines.Add(med);
                    }
                    db.BulkInsert<Medicine>(medicines);
                }
                   
            }
        }
    }
}

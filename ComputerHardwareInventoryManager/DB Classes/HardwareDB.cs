using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerHardwareInventoryManager.DB_Classes
{
    static class HardwareDB
    {
        static readonly HardwareContext Hcon;

        static HardwareDB()
        {
            Hcon = new HardwareContext();
        }

        public static List<HardwareProduct> GetHardwareProducts()
        {
            return Hcon.HardwareProducts.ToList();
        }

        public static void Insert(HardwareProduct HP)
        {
            if (IsValid(HP)) {
                Hcon.HardwareProducts.Add(HP);
                Hcon.SaveChanges();
            }
        }
            

        public static void Update(HardwareProduct HP)
        {
            Hcon.HardwareProducts.AddOrUpdate(HP);
            Hcon.SaveChanges();
        }

        public static void Delete(int id)
        {
            HardwareProduct deleteProd = Hcon.HardwareProducts.Where(p => p.ProductId == id).Single();
            Hcon.HardwareProducts.Remove(deleteProd);
            Hcon.SaveChanges();
        }

        public static bool IsValid(HardwareProduct HP)
        {
            if (HP.Title == "" ||
                HP.Manufacturer == "" ||
                HP.Description == "")
            {
                return false;
            }
            else if((double)HP.Price <= 0)
            {
                DialogResult drPrice = MessageBox.Show("Are you sure this product is 0 dollars? (y/n)",
                                                        "REALLY?",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                return drPrice == DialogResult.Yes;
            }
            else { return true; }
        }
    }
}

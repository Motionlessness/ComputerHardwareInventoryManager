using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerHardwareInventoryManager.DB_Classes
{
    static class HardwareDB
    {
        public static List<HardwareProduct> GetHardwareProducts()
        {
            HardwareContext Hcon = new HardwareContext();

            return Hcon.HardwareProducts.ToList();
        }

        public static void Insert(HardwareProduct HP)
        {
            if (IsValid(HP)) {
                HardwareContext Hcon = new HardwareContext();
                Hcon.HardwareProducts.Add(HP);
                Hcon.SaveChanges();
            }
        }
            

        public static void Update(HardwareProduct old, HardwareProduct HP)
        {
            HardwareContext Hcon = new HardwareContext();
            Hcon.HardwareProducts.Remove(old);
            Hcon.HardwareProducts.Add(HP);
            Hcon.SaveChanges();
        }

        public static void Delete(HardwareProduct HP)
        {
            HardwareContext Hcon = new HardwareContext();
            Hcon.HardwareProducts.Remove(HP);
            Hcon.SaveChanges();
        }

        public static Boolean IsValid(HardwareProduct HP)
        {
            if (HP.Title == "" ||
                HP.Manufacturer == "" ||
                HP.Description == "")
            {
                return false;
            }
            else if((double)HP.Price <= 0.00)
            {
                DialogResult drPrice = MessageBox.Show("Are you sure this product is 0 dollars? (y/n)",
                                                        "REALLY?",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (drPrice == DialogResult.Yes)
                {
                    return true;
                }
                else { return false; }
            }
            else { return true; }
        }
    }
}

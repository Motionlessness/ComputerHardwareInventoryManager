using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            else if(HP.Price == 0)
            {
                Console.WriteLine("Are you sure this product is 0 dollars? (y/n)");
                var answer = Convert.ToString(Console.ReadKey());
                if (answer.ToLower() == "y")
                {
                    return true;
                }
                else { return false; }
            }
            else { return true; }
        }
    }
}

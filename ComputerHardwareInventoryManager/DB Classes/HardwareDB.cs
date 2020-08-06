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
            HardwareContext Hcon = new HardwareContext();
            Hcon.HardwareProducts.Add(HP);
        }

        public static void Update(HardwareProduct old, HardwareProduct HP)
        {
            HardwareContext Hcon = new HardwareContext();
            Hcon.HardwareProducts.Remove(old);
            Hcon.HardwareProducts.Add(HP);

        }

        public static void Delete(HardwareProduct HP)
        {
            HardwareContext Hcon = new HardwareContext();
            Hcon.HardwareProducts.Remove(HP);
        }
    }
}

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
    }
}

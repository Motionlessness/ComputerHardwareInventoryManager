using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHardwareInventoryManager.Classes
{
    class HardwareProduct
    {
        /// <summary>
        /// the Id of the product in the database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the price of the Product
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// the manufacturer of the product
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// the type of the product
        /// </summary>
        public string Component { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A brief description of the product
        /// </summary>
        public string Description { get; set; }
    }
}

namespace ComputerHardwareInventoryManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HardwareProduct
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(60)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public override string ToString()
        {
            return Manufacturer + " " + Title;
        }
    }
}

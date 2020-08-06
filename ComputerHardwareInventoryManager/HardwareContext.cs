namespace ComputerHardwareInventoryManager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HardwareContext : DbContext
    {
        public HardwareContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<HardwareProduct> HardwareProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HardwareProduct>()
                .Property(e => e.Price)
                .HasPrecision(10, 4);

            modelBuilder.Entity<HardwareProduct>()
                .Property(e => e.Manufacturer)
                .IsUnicode(false);

            modelBuilder.Entity<HardwareProduct>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<HardwareProduct>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}

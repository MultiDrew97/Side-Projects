using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models.Inventory
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryItem> Inventory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryItem>().HasKey(x => x.ITEM_INDEX);
            base.OnModelCreating(modelBuilder);
        }
    }
}

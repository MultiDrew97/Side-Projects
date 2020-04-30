using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models
{
    public class Order_CountsContext : DbContext
    {
        public Order_CountsContext(DbContextOptions<Order_CountsContext> options)
            : base(options)
        {
        }

        public DbSet<Order_Counts> Order_Counts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Counts>().HasKey(x => x.order_index);
            base.OnModelCreating(modelBuilder);
        }
    }
}

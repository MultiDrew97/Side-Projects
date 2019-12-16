using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models.OrdersFolder.OrdersFiles
{
    public class Completed_OrdersContext : DbContext
    {
        public Completed_OrdersContext(DbContextOptions<Completed_OrdersContext> options)
            : base(options)
        {
        }

        public DbSet<Completed_Orders> Completed_Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Completed_Orders>().HasKey(x => x.order_number);
            base.OnModelCreating(modelBuilder);
        }
    }
}


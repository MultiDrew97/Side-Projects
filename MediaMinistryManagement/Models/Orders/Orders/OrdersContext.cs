using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options)
            : base(options)
        {
        }

        public DbSet<Orders> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>().HasKey(x => x.order_number);
            base.OnModelCreating(modelBuilder);
        }
    }
}


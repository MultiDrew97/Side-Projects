using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models.OrdersFolder.OrderSummary
{
    public class OrderSummaryContext : DbContext
    {
        public OrderSummaryContext(DbContextOptions<OrderSummaryContext> options)
            : base(options)
        {
        }

        public DbSet<OrderSummary> Order_Summary { get; set; }

        //found that I needed this from https://stackoverflow.com/questions/10236819/creating-primary-key-field-on-mvc-class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderSummary>().HasKey(x => x.ORDER_NUMBER);
            base.OnModelCreating(modelBuilder);
        }
    }
}

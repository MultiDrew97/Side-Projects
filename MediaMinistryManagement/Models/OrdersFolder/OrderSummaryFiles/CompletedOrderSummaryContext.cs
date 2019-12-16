using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models.OrdersFolder.OrderSummary
{
    public class CompletedOrderSummaryContext : DbContext
    {
        public CompletedOrderSummaryContext(DbContextOptions<CompletedOrderSummaryContext> options)
            : base(options)
        {
        }

        public DbSet<CompletedOrderSummary> Completed_Order_Summary { get; set; }

        //found that I needed this from https://stackoverflow.com/questions/10236819/creating-primary-key-field-on-mvc-class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompletedOrderSummary>().HasKey(x => x.ORDER_NUMBER);
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models
{
    public class Completed_Order_CountsContext : DbContext
    {
        public Completed_Order_CountsContext(DbContextOptions<Completed_Order_CountsContext> options)
            : base(options)
        {
        }

        public DbSet<Completed_Order_Counts> Completed_Order_Counts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Completed_Order_Counts>().HasKey(x => x.order_index);
            base.OnModelCreating(modelBuilder);
        }
    }
}

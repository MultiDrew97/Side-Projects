using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(x => x.PHONE_NUMBER);
            base.OnModelCreating(modelBuilder);
        }
    }
}

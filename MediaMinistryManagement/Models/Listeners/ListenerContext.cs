using Microsoft.EntityFrameworkCore;

namespace MediaMinistryManagement.Models
{
    public class ListenerContext : DbContext
    {
        public ListenerContext(DbContextOptions<ListenerContext> options) : base(options) { }

        public DbSet<EmailListener> Email_Listeners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailListener>().HasKey(x => x.EMAIL);
            base.OnModelCreating(modelBuilder);
        }
    }
}

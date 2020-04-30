using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMinistryManagement.Models
{
    public class ListenerContext : DbContext
    {
        public ListenerContext(DbContextOptions<ListenerContext> options) : base(options) { }

        public DbSet<Listener> Listeners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Listener>().HasKey(x => x.EMAIL);
            base.OnModelCreating(modelBuilder);
        }
    }
}

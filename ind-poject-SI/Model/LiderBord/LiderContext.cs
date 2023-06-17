using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_poject_SI.Model.LiderBord
{
    public class LiderContext : DbContext
    {
        public LiderContext(DbContextOptions<LiderContext> options) : base(options)
        { 
            Database.EnsureCreated();
        }

        public DbSet<Statistics> Statistics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statistics>().HasData(GetStatistics());
            base.OnModelCreating(modelBuilder);
        }
        private Statistics[] GetStatistics() => new Statistics[]
        {
            new Statistics
            {
                UserID = 1,
                Name = "Test",
                Press = 100,
                Squats = 100,
                PullUp = 20,
            }
        };
    }
}

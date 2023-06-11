using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_poject_SI.Model
{
    class ModelContext : DbContext
    {
        public DbSet <User> Users { get; set; }

        public DbSet <Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DataBase.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}

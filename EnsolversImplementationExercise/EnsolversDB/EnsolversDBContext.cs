using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsolversDB
{
    public class EnsolversDBContext : DbContext
    {
        public DbSet<Folder> Folders { get; set; }

        public DbSet<Item> Items { get; set; }

        public EnsolversDBContext(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Folder>().Property(c => c.Name).IsRequired();       

            modelBuilder.Entity<Item>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<Item>().Property(c => c.Status).IsRequired();
            
        }
    }
}

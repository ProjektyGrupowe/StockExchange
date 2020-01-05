using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockAPI.Models.ApiDataModels;
using StockAPI.Models.UserModels;

namespace StockAPI.Data
{
    public class StockAPIContext : DbContext
    {
        public StockAPIContext (DbContextOptions<StockAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockData>()
                .HasOne(p => p.Quote)
                .WithOne(i => i.StockData)
                .HasForeignKey<Quote>(b => b.StockDataID);

            modelBuilder.Entity<Chart>()
                        .HasOne(s => s.StockData)
                        .WithMany(c => c.Chart)
                        .HasForeignKey(c => c.StockDataID);
        }

        public DbSet<StockData> StockData { get; set; }
        public DbSet<Chart> Chart { get; set; }
        public DbSet<Quote> Quote { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

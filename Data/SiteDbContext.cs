using System;
using Microsoft.EntityFrameworkCore;
using blogs.Model;
using blogs.Data;

namespace blogs.Data {
    public class SiteDbContext : DbContext {
        public SiteDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        
    }
}
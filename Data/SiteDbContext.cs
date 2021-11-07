using System;
using Microsoft.EntityFrameworkCore;
using blogs.Model;

namespace blogs.Data {
    public class SiteDbContext : DbContext {
        public SiteDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        
    }
}
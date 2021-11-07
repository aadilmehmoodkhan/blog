using System;
using blogs.Model;
using Microsoft.EntityFrameworkCore;

namespace blogs.Data {
    public class SeedDatabase {
        public SeedDatabase(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category{ Id = 1, Name = "ASP.NET", Description = "ASP.NET is the Microsoft's web applications technology", Active = true, CreatedOn = DateTime.Now },
                new Category{ Id = 2, Name = "C#", Description = "", Active = true, CreatedOn = DateTime.Now },
                new Category{ Id = 3, Name = "Entity Framework", Description = "", Active = true, CreatedOn = DateTime.Now },
                new Category{ Id = 4, Name = "SQL Server", Description = "", Active = true, CreatedOn = DateTime.Now },
                new Category{ Id = 5, Name = "AWS", Description = "", Active = true, CreatedOn = DateTime.Now },
                new Category{ Id = 6, Name = "Redshift", Description = "", Active = true, CreatedOn = DateTime.Now },
                new Category{ Id = 7, Name = "AWS Lambda Functions", Description = "", Active = true, CreatedOn = DateTime.Now }
            );
        }
    }
}
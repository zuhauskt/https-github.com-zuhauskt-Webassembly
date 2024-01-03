
using System.Collections.Generic;
using Webassemblyproject.Shared; 
using Microsoft.EntityFrameworkCore;

namespace Webassemblyproject.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

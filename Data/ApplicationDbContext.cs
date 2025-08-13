using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WorkConnect.Models;

namespace WorkConnect.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}

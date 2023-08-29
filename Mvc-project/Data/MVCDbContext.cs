using Microsoft.EntityFrameworkCore;
using Mvc_project.Models.Tables;


namespace Mvc_project.Data
{
    public class MVCDbContext : DbContext
    {

        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
    }
}

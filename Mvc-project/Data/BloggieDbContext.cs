using Microsoft.EntityFrameworkCore;
using Mvc_project.Models.Tables;

namespace Bloggie.Web.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options) 
        { 

        }

        public DbSet<Cities> Cities { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        //public DbSet<BlogPost> Blogpost { get; set; }
        //public DbSet<Tag> Tags { get; set; }
    }

}

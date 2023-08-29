using Microsoft.EntityFrameworkCore;

namespace Mvc_project.Data
{
    public class DbContext
    {
        private DbContextOptions options;

        public DbContext(DbContextOptions options)
        {
            this.options = options;
        }
    }
}
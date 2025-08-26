using Microsoft.EntityFrameworkCore;

namespace PropertyManagementApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet<T> properties here for your entities
        // public DbSet<Property> Properties { get; set; }
    }
}

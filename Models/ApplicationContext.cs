using Microsoft.EntityFrameworkCore;
using ValidateChecker.Configuration;

namespace ValidateChecker.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Init.GetConnectionString());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using UserManagementAPI.Models.Entities;

namespace UserManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        public DbSet<User> Users { get; set; }
    }
}

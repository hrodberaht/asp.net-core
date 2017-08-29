using Microsoft.EntityFrameworkCore;
using src.Models;

namespace SportsStore.Models 
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}
        public DbSet<Product> Products { get; set; }
    }
}
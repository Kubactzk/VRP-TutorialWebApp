using Microsoft.EntityFrameworkCore;
using VRP.Models;

namespace VRP.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Depot> Depots { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

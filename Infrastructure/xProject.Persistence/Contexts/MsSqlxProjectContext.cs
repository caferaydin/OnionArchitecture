using Microsoft.EntityFrameworkCore;
using xProject.Domain.Concrete;

namespace xProject.Persistence.Contexts
{
    public class MsSqlxProjectContext : DbContext
    {
        public MsSqlxProjectContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

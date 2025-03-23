using Microsoft.EntityFrameworkCore;

namespace Customer.Api
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Entities.Customer> Customers { get; set; }

        public DbSet<Entities.Vehicle> Vehicles { get; set; }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

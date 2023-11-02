using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Models.Context
{
    public class PostgreeContext : DbContext
    {
        public PostgreeContext() { }

        public PostgreeContext(DbContextOptions<PostgreeContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("6e32a998-44b1-4e7c-bfb4-654171a29f11"),
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

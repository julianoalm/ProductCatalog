using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data.Maps;
using ProjectCatalog.Models;

namespace ProjectCatalog.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.173.109.8\BOTIDEV2016;User ID=testador;Password=test123;Database=prodcat;Max Pool Size=1000;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
        }
    }
}

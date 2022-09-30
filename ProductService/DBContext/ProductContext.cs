using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.DContext
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Nombre = "Electronics",
                    Descripcion = "Electronic Items",
                },
                new Category
                {
                    Id = 2,
                    Nombre = "Clothes",
                    Descripcion = "Dresses",
                },
                new Category
                {
                    Id = 3,
                    Nombre = "Grocery",
                    Descripcion = "Grocery Items",
                }
            );
        }

    }
}

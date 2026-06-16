using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    Name = "Coca-cola",
                    Price = 5.00m,
                    Description = "Refrigerante sabor cola",
                    CategoryName = "Bebidas",
                    ImageURL = "https://www.coca-cola.com.br/content/dam/one-brasil/coca-cola/pt-br/desktop/packshot-coca-cola-350ml.png"
                },
                new Product
                {
                    Id = 4,
                    Name = "Pepsi",
                    Price = 4.50m,
                    Description = "Refrigerante sabor cola",
                    CategoryName = "Bebidas",
                    ImageURL = "https://www.pepsico.com.br/uploads/images/products/pepsi-350ml.png"
                },
                new Product
                {
                    Id = 5,
                    Name = "Fanta Laranja",
                    Price = 4.00m,
                    Description = "Refrigerante sabor laranja",
                    CategoryName = "Bebidas",
                    ImageURL = "https://www.coca-cola.com.br/content/dam/one-brasil/fanta/pt-br/desktop/packshot-fanta-laranja-350ml.png"
                }
            );
        }

    }
}

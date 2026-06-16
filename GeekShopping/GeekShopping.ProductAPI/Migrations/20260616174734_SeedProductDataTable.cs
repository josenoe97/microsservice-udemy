using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 3L, "Bebidas", "Refrigerante sabor cola", "https://www.coca-cola.com.br/content/dam/one-brasil/coca-cola/pt-br/desktop/packshot-coca-cola-350ml.png", "Coca-cola", 5.00m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 4L, "Bebidas", "Refrigerante sabor cola", "https://www.pepsico.com.br/uploads/images/products/pepsi-350ml.png", "Pepsi", 4.50m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 5L, "Bebidas", "Refrigerante sabor laranja", "https://www.coca-cola.com.br/content/dam/one-brasil/fanta/pt-br/desktop/packshot-fanta-laranja-350ml.png", "Fanta Laranja", 4.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AspMvcCoreWebAPICfDemo.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductCode);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "Speaker", 30000.00m },
                    { 2, "Desktop", 30000.00m },
                    { 3, "Laptops", 25000.00m },
                    { 4, "Gaming Pc's", 60000.00m },
                    { 5, "Servers", 100000.00m },
                    { 6, "Tablets", 5000.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

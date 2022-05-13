using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Server.Migrations
{
    public partial class SeedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Description 1", "ImageUrl1", 9.99m, "Title 1" },
                    { 2, "Description 2", "ImageUrl2", 9.99m, "Title 2" },
                    { 3, "Description 3", "ImageUrl3", 9.99m, "Title 3" },
                    { 4, "Description 4", "ImageUrl4", 9.99m, "Title 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

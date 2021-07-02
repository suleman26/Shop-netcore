using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dutch_retreat.Migrations
{
    public partial class newseeder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[] { 98, null, "500 G SSD", "SK-A-2351", "Apple", new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigeria", "Laptop", 89000m, "6GB RAM", "MacBook Pro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber" },
                values: new object[] { 79, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "78" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dutch_retreat.Migrations
{
    public partial class artadde2s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2345,
                columns: new[] { "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[] { "2017", "intel core i7", "SK-A-2344", "HP", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Made in nigeria", "Laptop", 500000m, "512G SSD", "HP Envy x360" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 232, "2019", "intel core i7", "SK-A-3066", "Lenovo", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Made in nigeria", "Laptop", 350000m, "512G SSD", "Lenovo Yoga" },
                    { 678, "2019", "128 G", "SK-A-3137", "Apple", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Made in nigeria", "Phones", 450000m, "215G SSD", "Iphone 11 pro max" },
                    { 6734, "2021", "64 inch", "SK-A-2351", "LG", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "Made in nigeria", "TV", 567833m, "512G SSD", "Oled TV" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6734);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber" },
                values: new object[] { 123, new DateTime(2021, 5, 16, 10, 25, 25, 583, DateTimeKind.Utc).AddTicks(6597), "234" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2345,
                columns: new[] { "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[] { null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test", 2563m, null, "test tittle" });
        }
    }
}

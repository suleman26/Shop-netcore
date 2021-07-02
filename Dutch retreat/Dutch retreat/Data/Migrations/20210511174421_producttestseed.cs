using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dutch_retreat.Migrations
{
    public partial class producttestseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                column: "OrderDate",
                value: new DateTime(2021, 5, 11, 17, 44, 20, 610, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtDating", "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistDeathDate", "ArtistNationality", "Category", "Price", "Size", "Title" },
                values: new object[] { 2345, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test", 2563m, null, "test tittle" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2345);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                column: "OrderDate",
                value: new DateTime(2021, 5, 11, 17, 38, 19, 671, DateTimeKind.Utc).AddTicks(5060));
        }
    }
}

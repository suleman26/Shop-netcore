using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dutch_retreat.Migrations
{
    public partial class identitity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                column: "OrderDate",
                value: new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "ArtistBirthDate",
                value: new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79,
                column: "OrderDate",
                value: new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "ArtistBirthDate",
                value: new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dutch_retreat.Migrations
{
    public partial class artadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                column: "OrderDate",
                value: new DateTime(2021, 5, 15, 19, 37, 32, 42, DateTimeKind.Utc).AddTicks(8382));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                column: "OrderDate",
                value: new DateTime(2021, 5, 11, 17, 44, 20, 610, DateTimeKind.Utc).AddTicks(6796));
        }
    }
}

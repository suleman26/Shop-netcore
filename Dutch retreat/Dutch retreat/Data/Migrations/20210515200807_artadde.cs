using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dutch_retreat.Migrations
{
    public partial class artadde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                column: "OrderDate",
                value: new DateTime(2021, 5, 15, 20, 8, 6, 292, DateTimeKind.Utc).AddTicks(7358));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 123,
                column: "OrderDate",
                value: new DateTime(2021, 5, 15, 19, 37, 32, 42, DateTimeKind.Utc).AddTicks(8382));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dutch_retreat.Migrations
{
    public partial class identiti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtDating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ArtDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ArtId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ArtistBirthDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ArtistDeathDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ArtistNationality",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Productimg",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "Description", "Productimg" },
                values: new object[] { new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "500 G SSD", "SK-A-2351" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Productimg",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ArtDating",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArtDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArtId",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ArtistBirthDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ArtistDeathDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ArtistNationality",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ArtDescription", "ArtId", "Artist", "ArtistBirthDate", "ArtistNationality", "Size" },
                values: new object[] { "500 G SSD", "SK-A-2351", "Apple", new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "Nigeria", "6GB RAM" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class seeding_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 309);

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 2,
                column: "CampusNaam",
                value: "Lorem Ipsum");

            migrationBuilder.InsertData(
                table: "Landen",
                columns: new[] { "LandCode", "Naam" },
                values: new object[] { "GB", "Groot-Brittanië" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "LandCode",
                keyValue: "GB");

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 2,
                column: "CampusNaam",
                value: "Delos");

            migrationBuilder.InsertData(
                table: "Docenten",
                columns: new[] { "DocentId", "CampusId", "Familienaam", "Geboortedatum", "Geslacht", "HeeftRijbewijs", "InDienst", "LandCode", "Voornaam", "Maandwedde" },
                values: new object[] { 309, 1, "Wouters", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jozef", 1100m });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class met_annotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wedde",
                table: "Docenten",
                newName: "Maandwedde");

            migrationBuilder.RenameColumn(
                name: "Naam",
                table: "Campussen",
                newName: "CampusNaam");

            migrationBuilder.AlterColumn<string>(
                name: "Voornaam",
                table: "Docenten",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Familienaam",
                table: "Docenten",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Maandwedde",
                table: "Docenten",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<bool>(
                name: "HeeftRijbewijs",
                table: "Docenten",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InDienst",
                table: "Docenten",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LandCode",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandCode1",
                table: "Docenten",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gemeente",
                table: "Campussen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CampusNaam",
                table: "Campussen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Landen",
                columns: table => new
                {
                    LandCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landen", x => x.LandCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docenten_LandCode1",
                table: "Docenten",
                column: "LandCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Docenten_Landen_LandCode1",
                table: "Docenten",
                column: "LandCode1",
                principalTable: "Landen",
                principalColumn: "LandCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docenten_Landen_LandCode1",
                table: "Docenten");

            migrationBuilder.DropTable(
                name: "Landen");

            migrationBuilder.DropIndex(
                name: "IX_Docenten_LandCode1",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "HeeftRijbewijs",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "InDienst",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "LandCode",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "LandCode1",
                table: "Docenten");

            migrationBuilder.RenameColumn(
                name: "Maandwedde",
                table: "Docenten",
                newName: "Wedde");

            migrationBuilder.RenameColumn(
                name: "CampusNaam",
                table: "Campussen",
                newName: "Naam");

            migrationBuilder.AlterColumn<string>(
                name: "Voornaam",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Familienaam",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<decimal>(
                name: "Wedde",
                table: "Docenten",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<string>(
                name: "Gemeente",
                table: "Campussen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Campussen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class test_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docenten_Landen_LandCode1",
                table: "Docenten");

            migrationBuilder.DropIndex(
                name: "IX_Docenten_LandCode1",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "LandCode1",
                table: "Docenten");

            migrationBuilder.AlterColumn<string>(
                name: "LandCode",
                table: "Docenten",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Geboortedatum",
                table: "Docenten",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Geslacht",
                table: "Docenten",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Docenten_LandCode",
                table: "Docenten",
                column: "LandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Docenten_Landen_LandCode",
                table: "Docenten",
                column: "LandCode",
                principalTable: "Landen",
                principalColumn: "LandCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docenten_Landen_LandCode",
                table: "Docenten");

            migrationBuilder.DropIndex(
                name: "IX_Docenten_LandCode",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "Geboortedatum",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "Geslacht",
                table: "Docenten");

            migrationBuilder.AlterColumn<string>(
                name: "LandCode",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandCode1",
                table: "Docenten",
                type: "nvarchar(450)",
                nullable: true);

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
    }
}

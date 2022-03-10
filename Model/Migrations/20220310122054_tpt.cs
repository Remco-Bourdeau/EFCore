using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class tpt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TPTCursussen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TPTCursussen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TPTKlassikaleCursussen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Van = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tot = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TPTKlassikaleCursussen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TPTKlassikaleCursussen_TPTCursussen_ID",
                        column: x => x.ID,
                        principalTable: "TPTCursussen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TPTZelfstudieCursussen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    AantalDagen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TPTZelfstudieCursussen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TPTZelfstudieCursussen_TPTCursussen_ID",
                        column: x => x.ID,
                        principalTable: "TPTCursussen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TPTKlassikaleCursussen");

            migrationBuilder.DropTable(
                name: "TPTZelfstudieCursussen");

            migrationBuilder.DropTable(
                name: "TPTCursussen");
        }
    }
}

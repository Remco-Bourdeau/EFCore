using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class first_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campussen",
                columns: table => new
                {
                    CampusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Straat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huisnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gemeente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campussen", x => x.CampusId);
                });

            migrationBuilder.CreateTable(
                name: "Docenten",
                columns: table => new
                {
                    DocentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familienaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wedde = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CampusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docenten", x => x.DocentId);
                    table.ForeignKey(
                        name: "FK_Docenten_Campussen_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campussen",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docenten_CampusId",
                table: "Docenten",
                column: "CampusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docenten");

            migrationBuilder.DropTable(
                name: "Campussen");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class tph2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "TPHCursussen",
                newName: "Cursustype");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cursustype",
                table: "TPHCursussen",
                newName: "Discriminator");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class metadres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "Campussen",
                newName: "PostCd");

            migrationBuilder.RenameColumn(
                name: "Huisnummer",
                table: "Campussen",
                newName: "HuisNr");

            migrationBuilder.AddColumn<string>(
                name: "GemeenteThuis",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GemeenteVerblijf",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HuisNrThuis",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HuisNrVerblijf",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCdThuis",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCdVerblijf",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StraatThuis",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StraatVerblijf",
                table: "Docenten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gemeente",
                table: "Campussen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GemeenteThuis",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "GemeenteVerblijf",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "HuisNrThuis",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "HuisNrVerblijf",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "PostCdThuis",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "PostCdVerblijf",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "StraatThuis",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "StraatVerblijf",
                table: "Docenten");

            migrationBuilder.RenameColumn(
                name: "PostCd",
                table: "Campussen",
                newName: "Postcode");

            migrationBuilder.RenameColumn(
                name: "HuisNr",
                table: "Campussen",
                newName: "Huisnummer");

            migrationBuilder.AlterColumn<string>(
                name: "Gemeente",
                table: "Campussen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 1,
                columns: new[] { "Gemeente", "Huisnummer", "Postcode", "Straat" },
                values: new object[] { "Antwerpen", "22", "2018", "Somersstraat" });

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 2,
                columns: new[] { "Gemeente", "Huisnummer", "Postcode", "Straat" },
                values: new object[] { "Dendermonde", "17", "9200", "Oude Vest" });

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 3,
                columns: new[] { "Gemeente", "Huisnummer", "Postcode", "Straat" },
                values: new object[] { "Genk", "37", "3600", "Europalaan" });

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 4,
                columns: new[] { "Gemeente", "Huisnummer", "Postcode", "Straat" },
                values: new object[] { "Heverlee", "2", "3001", "Interleuvenlaan" });

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 5,
                columns: new[] { "Gemeente", "Huisnummer", "Postcode", "Straat" },
                values: new object[] { "Wevelgem", "10", "8560", "Vlamingstraat" });

            migrationBuilder.UpdateData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 6,
                columns: new[] { "Gemeente", "Huisnummer", "Postcode", "Straat" },
                values: new object[] { "Oostende", "4", "8400", "Akkerstraat" });
        }
    }
}

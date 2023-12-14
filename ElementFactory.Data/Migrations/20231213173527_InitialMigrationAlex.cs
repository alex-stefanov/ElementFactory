using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class InitialMigrationAlex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Question",
                comment: "Question Class");

            migrationBuilder.AlterTable(
                name: "FounderChemicalElement",
                comment: "Founder Chemical Element Class");

            migrationBuilder.AlterTable(
                name: "Founder",
                comment: "Founder Class");

            migrationBuilder.AlterTable(
                name: "ChemicalType",
                comment: "Chemical Type Class");

            migrationBuilder.AlterTable(
                name: "ChemicalElementQuestion",
                comment: "Chemical Element Question Class");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Question",
                oldComment: "Question Class");

            migrationBuilder.AlterTable(
                name: "FounderChemicalElement",
                oldComment: "Founder Chemical Element Class");

            migrationBuilder.AlterTable(
                name: "Founder",
                oldComment: "Founder Class");

            migrationBuilder.AlterTable(
                name: "ChemicalType",
                oldComment: "Chemical Type Class");

            migrationBuilder.AlterTable(
                name: "ChemicalElementQuestion",
                oldComment: "Chemical Element Question Class");
        }
    }
}

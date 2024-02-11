using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class OtherChangesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 112,
                column: "Description",
                value: "При ΔG < 0 реакцията протича спонтанно, а при ΔG = 0 системата се намира в динамично равновесие.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 112,
                column: "Description",
                value: "При ΔG < 0 реакцията протича спонтанно, а при ΔG = 0 системата се намира в динамично равновесие");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedEnglishName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EnglishName",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnglishName",
                table: "ChemicalElements");
        }
    }
}

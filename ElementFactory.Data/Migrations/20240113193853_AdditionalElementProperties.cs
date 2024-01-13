using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AdditionalElementProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BoilingPoint",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Electronegativity",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MeltingPoint",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "ChemicalElements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "YearFound",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoilingPoint",
                table: "ChemicalElements");

            migrationBuilder.DropColumn(
                name: "Electronegativity",
                table: "ChemicalElements");

            migrationBuilder.DropColumn(
                name: "MeltingPoint",
                table: "ChemicalElements");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ChemicalElements");

            migrationBuilder.DropColumn(
                name: "YearFound",
                table: "ChemicalElements");
        }
    }
}

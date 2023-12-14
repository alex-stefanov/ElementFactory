using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class InitialMigrationAlex1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalType",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalType",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }
    }
}

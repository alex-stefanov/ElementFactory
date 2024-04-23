using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class TestMakerUpdate_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MakerId",
                table: "Tests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_MakerId",
                table: "Tests",
                column: "MakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_AspNetUsers_MakerId",
                table: "Tests",
                column: "MakerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_AspNetUsers_MakerId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_MakerId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "MakerId",
                table: "Tests");
        }
    }
}

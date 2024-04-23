using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class UserChanges_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "School",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SchoolId",
                table: "AspNetUsers",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Schools_SchoolId",
                table: "AspNetUsers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Schools_SchoolId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SchoolId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "School",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class NewUserPropertiesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserUser",
                columns: table => new
                {
                    StudentsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeachersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUser", x => new { x.StudentsId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_UserUser_AspNetUsers_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUser_AspNetUsers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserUser_TeachersId",
                table: "UserUser",
                column: "TeachersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserUser");
        }
    }
}

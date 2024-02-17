using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class NewEntityFlashcard1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Flashcards",
                comment: "Flashcard Class");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Flashcards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Flashcard Title",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Flashcards",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                comment: "Flashcard Content",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Flashcards",
                type: "int",
                nullable: false,
                comment: "Flashcard identificator",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Flashcards",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Flashcards");

            migrationBuilder.AlterTable(
                name: "Flashcards",
                oldComment: "Flashcard Class");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Flashcards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Flashcard Title");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Flashcards",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldComment: "Flashcard Content");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Flashcards",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Flashcard identificator")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}

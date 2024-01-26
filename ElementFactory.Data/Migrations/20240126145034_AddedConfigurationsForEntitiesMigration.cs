using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedConfigurationsForEntitiesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "Answers",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[] { 1, "В коя група е химичният елемен Na", "Първа А" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Title" },
                values: new object[] { 1, "7 клас", "Метали. Натрий и неговите съединения" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Втора А" },
                    { 2, 1, "Седма А" },
                    { 3, 1, "Първа А" },
                    { 4, 1, "Първа Б" }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Answers",
                newName: "AnswerId");
        }
    }
}

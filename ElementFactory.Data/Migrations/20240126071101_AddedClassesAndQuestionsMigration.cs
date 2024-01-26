using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedClassesAndQuestionsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChemicalElementsQuestions");

            migrationBuilder.AddColumn<string>(
                name: "RightAnswer",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Answer Class");

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                },
                comment: "Test Class");

            migrationBuilder.CreateTable(
                name: "QuestionsTests",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsTests", x => new { x.QuestionId, x.TestId });
                    table.ForeignKey(
                        name: "FK_QuestionsTests_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionsTests_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsTests_TestId",
                table: "QuestionsTests",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "QuestionsTests");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropColumn(
                name: "RightAnswer",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "ChemicalElementsQuestions",
                columns: table => new
                {
                    ChemicalElementSymbol = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalElementsQuestions", x => new { x.ChemicalElementSymbol, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_ChemicalElementsQuestions_ChemicalElements_ChemicalElementSymbol",
                        column: x => x.ChemicalElementSymbol,
                        principalTable: "ChemicalElements",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChemicalElementsQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Chemical Element Question Class");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalElementsQuestions_QuestionId",
                table: "ChemicalElementsQuestions",
                column: "QuestionId");
        }
    }
}

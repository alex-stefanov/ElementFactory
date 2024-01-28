using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class CorrectedSeveralQuestionInTest8GradeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                column: "RightAnswer",
                value: "Ca + 2H2O => Ca(OH)2 + H2");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Ca се съхранява под петрол или инертен газ.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Какъв е цветът на пламъка при гореното на Ca?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "Разтворът на Ca(OH)2 е с pH:");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                column: "RightAnswer",
                value: "Ca + 2H2O => Ca(OH)2+H2");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Ca се съхранява по петрол или инертен газ");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Какъв е цвета на пламъка при гореното на Ca?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "Разтоворът на Ca(OH)2 е с pH:");
        }
    }
}

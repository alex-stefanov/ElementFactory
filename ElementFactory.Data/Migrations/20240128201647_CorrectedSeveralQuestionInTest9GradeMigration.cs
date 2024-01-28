using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class CorrectedSeveralQuestionInTest9GradeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 146,
                column: "Value",
                value: "Калцият не взаимодейства с киселини");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 158,
                column: "Value",
                value: "Ca + 2H2O => Ca(OH)2 + H2");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Реакцията \"Гасене на вар\" е реакция на CaO с вода, при коятo се получава/т:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Какъв е цветът на пламъка при горенето на Ca?");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 146,
                column: "Value",
                value: "Калция не взаимодейства с киселини");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 158,
                column: "Value",
                value: "Ca + 2H2O => Ca(OH)2+H2");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Реакцията \"Гасене на вар\" е ракция на CaO с вода, при коята се получава/т:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Какъв е цветът на пламъка при гореното на Ca?");
        }
    }
}

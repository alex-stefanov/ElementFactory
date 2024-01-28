using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class CorrectedSeveralQuestionInTest9Grade2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 203,
                column: "Value",
                value: "Висока температура");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 204,
                column: "Value",
                value: "Високо налягане");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 205,
                column: "Value",
                value: "Катализатор (Ni)");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "Всяко ОС при взаимодействие с кислород (горене) се разлага до въглероден диоксид и вода");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "Кое от от следните съединения е нонан?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Каква е общата молекулна формула на алкените?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Характерни за алкените са заместителните реакции, поради наличието на сложната двойна връзка.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "\"Хидрирането\" на алкени протича при наличието на:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "При присъединяването на полярни H-съдържащи молекули към молекули на несиметрични алкени се спазва правилото на:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "2,4,6-тринитро толуен (TNT) се получава при взаимодействието на:");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 203,
                column: "Value",
                value: "Температура");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 204,
                column: "Value",
                value: "Налягане");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 205,
                column: "Value",
                value: "Катализатор(Ni)");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "Всяко ОС при взаимодействие с кислород(горене) се разлага до въглероден диоксид и вода");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "Кое от от следните съединения е нонан");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Каква е общата молекулна формула на алкените");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Характерни за алкените са заместителните реакции, поради наличието на сложната двойна връзка");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "\"Хидрирането\" на алкени протична при наличието на:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "При присъединяването на полярни H-съдържащи молекули към молекули на несиметрияни алкени се спазва правилото на:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "2,4,6-тринитро толуен(TNT) се получава при взаимодействието на:");
        }
    }
}

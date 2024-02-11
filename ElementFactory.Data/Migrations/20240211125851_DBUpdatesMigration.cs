using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class DBUpdatesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Кои киселини се получават при директно взаимодействие на хлор с вода?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Газът хлор има силен, приятен мирис.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Реакцията \"Гасене на вар\" е реакция на CaO с вода, при която се получава/т:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "Кое от от следните съединения е нонан:");

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
                keyValue: 63,
                column: "Description",
                value: "Изчислете топлината на образуване на NH3 според уравнението в kJ, закръглено до първия знак след запетаята: N2 + 3H2 => 2NH3 + 92,4 kJ");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "Дадено:\r\n                C6H6 + 15/2 O2 => 6CO2 + 3H20 + Q\r\n                Q=3271kJ,\r\n                Qобразуване(CO2) = 394kJ/mol,\r\n                Qобразуване(H20) = 285.8kJ/mol\r\n                Търсим:\r\n                Qобразуване(C6H6) = ?kJ, закръглено до първия знак след запетаята.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Ако в хомогенния едностадиен процес 2CO + O2 => 2CO2 концентрацията на CO се увеличи 3 пъти при t = const, то с колко пъти новата скорост ще е по-голяма от старата?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "S(тв) + H2(г) => H2S(г) + 4.8kJ. Изчислете количеството обменена топлина в kJ, закръглено до първия знак след запетаята, ако 8 грама сяра реагират по даденото химично уравнение (счита се, че M(S) = 32.0).");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 87,
                column: "RightAnswer",
                value: "Част от пространството, което е около самото ядро, в която шансът за намиране на електрона е приблизително 90%");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Кои киселини се получават при директно взаимодействие на хлор с вода");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Газът хлор има силен, приятен мирис");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Реакцията \"Гасене на вар\" е ракция на CaO с вода, при коята се получава/т:");

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
                keyValue: 63,
                column: "Description",
                value: "Изчислете топлината на образуване на NH3 според уравнението в kJ закръглено до първия знак след запетаята: N2 + 3H2 => 2NH3 + 92,4 kJ");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "Дадено:\r\n                C6H6 + 15/2 O2 => 6CO2 + 3H20 + Q\r\n                Q=3271kJ\r\n                Qобразуване(CO2) = 394kJ/mol\r\n                Qобразуване(H20) = 285.8kJ/mol\r\n                Търсим:\r\n                Qобразуване(C6H6) = ?kJ, закръглено до първия знак след запетаята");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Ако в хомогенния едностадиен процес 2CO + O2 => 2CO2, концентрацията на CO се увеличи 3 пъти при t = const то с колко пъти новата скорост ще е по-голяма от старата?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "S(тв) + H2(г) => H2S(г) + 4.8kJ. Изчислете количеството обменена топлина в kJ, закръглено до първия знак след запетаята, ако 8 грама сяра реагират по даденото химично уравнение (счита се,че M(S)=32.0)");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 87,
                column: "RightAnswer",
                value: "Част от пространството, което е около самото ядро, в която шанса за намиране на електрона е приблизително 90%");
        }
    }
}

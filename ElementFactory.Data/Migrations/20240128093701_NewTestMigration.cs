using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class NewTestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tests",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "В какъв йон се превръща атомът на хлора при реакция?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "От коя валентност е хлорът в съединението си с водорода?");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
                    { 31, "Простото вещество Ca е:", "Алкалоземен метал" },
                    { 32, "С какъв строеж е простото вещество Ca?", "Кристален" },
                    { 33, "С каква валентност участва в съединенията си Ca?", "2" },
                    { 34, "Под какво име е известно съединението CaO?", "Негасена вар" },
                    { 35, "В коя група е Ca?", "Втора А" },
                    { 36, "При взаимодействието на Ca с кислород се получава:", "CaO" },
                    { 37, "Реакцията \"Гасене на вар\" е ракция на CaO с вода, при коята се получава/т:", "Ca(OH)2" },
                    { 38, "При взаимодействие на Ca с халогеноводородна киселина се получава:", "Сол" },
                    { 39, "Простото вещество Ca е газ с метален блясък и висока електропроводимост.", "Грешно" },
                    { 40, "Какъв характер проявява водният разтвор на калциевия дихидроксид?", "Основен" },
                    { 41, "Кое от следните уравнения за Ca и неговите съединения е изравнено вярно?", "Ca + 2H2O => Ca(OH)2+H2" },
                    { 42, "Ca се съхранява по петрол или инертен газ", "Вярно" },
                    { 43, "Какъв е цвета на пламъка при гореното на Ca?", "Керемиденочервен" },
                    { 44, "Реакцията \"Шумяща проба\" се наблюдава при взаимодействието на:", "CaCO3 с киселина" },
                    { 45, "Разтоворът на Ca(OH)2 е с pH:", "11" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Title" },
                values: new object[,]
                {
                    { 3, "8-9 клас", "Алкалоземни метали. Калций и неговите съединения" },
                    { 4, "8-9 клас", "Органична химия. Въглерод и неговите органични съединения" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 117, 31, "Алкален метал" },
                    { 118, 31, "Алкалоземен метал" },
                    { 119, 31, "Халоген" },
                    { 120, 31, "Преходен метал" },
                    { 121, 32, "Молекулен" },
                    { 122, 32, "Йонен" },
                    { 123, 32, "Кристален" },
                    { 124, 32, "Атомен" },
                    { 125, 33, "1" },
                    { 126, 33, "2" },
                    { 127, 33, "3" },
                    { 128, 33, "4" },
                    { 129, 34, "Гасена вар" },
                    { 130, 34, "Негасена вар" },
                    { 131, 34, "Бистра варна вода(БВВ)" },
                    { 132, 34, "Син камък" },
                    { 133, 35, "Втора А" },
                    { 134, 35, "Първа Б" },
                    { 135, 35, "Седма А" },
                    { 136, 35, "Втора Б" },
                    { 137, 36, "CaH2" },
                    { 138, 36, "CaO2" },
                    { 139, 36, "Ca(OH)2" },
                    { 140, 36, "CaO" },
                    { 141, 37, "Ca(OH)2" },
                    { 142, 37, "Ca(OH)2 и H2" },
                    { 143, 37, "CaOH и H2" },
                    { 144, 37, "CaOH" },
                    { 145, 38, "Основа" },
                    { 146, 38, "Калция не взаимодейства с киселини" },
                    { 147, 38, "Киселина" },
                    { 148, 38, "Сол" },
                    { 149, 39, "Вярно" },
                    { 150, 39, "Грешно" },
                    { 151, 39, "Киселинен" },
                    { 152, 39, "Основен" },
                    { 153, 39, "Неутрален" },
                    { 154, 39, "Смесен" },
                    { 155, 40, "CaO + H2O => CaOH + H2" },
                    { 156, 40, "Ca + 2HCl => CaCl + 2H" },
                    { 157, 40, "Ca + H2 => 2CaH" },
                    { 158, 40, "Ca + 2H2O => Ca(OH)2+H2" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 159, 41, "Вярно" },
                    { 160, 41, "Грешно" },
                    { 161, 42, "Бял" },
                    { 162, 42, "Керемиденочервен" },
                    { 163, 42, "Син" },
                    { 164, 42, "Зелен" },
                    { 165, 43, "Ca(OH)2 с вода" },
                    { 166, 43, "Ca с киселина" },
                    { 167, 43, "CaCO3 с киселина" },
                    { 168, 43, "Ca с киселинен оксид" },
                    { 169, 44, "4" },
                    { 170, 44, "7" },
                    { 171, 44, "2" },
                    { 172, 44, "11" }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 31, 3 },
                    { 32, 3 },
                    { 33, 3 },
                    { 34, 3 },
                    { 35, 3 },
                    { 36, 3 },
                    { 37, 3 },
                    { 38, 3 },
                    { 39, 3 },
                    { 40, 3 },
                    { 41, 3 },
                    { 42, 3 },
                    { 43, 3 },
                    { 44, 3 },
                    { 45, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 34, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 35, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 36, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 38, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 39, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 40, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 41, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 42, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 43, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 44, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tests",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "В какъв йон се превръща атома на хлора при реакция?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "От коя валентност е хлора в съединението си с водорода?");
        }
    }
}

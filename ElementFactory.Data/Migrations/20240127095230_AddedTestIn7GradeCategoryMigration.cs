using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedTestIn7GradeCategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "В коя група е химичният елемент Na?");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
                    { 2, "Какво по характер е простото вещество на Na?", "Метал" },
                    { 3, "Натрият взаимодейства със: ", "Неметали, киселини и вода" },
                    { 4, "При взаимодействие на Na с вода се получава:", "NaOH + H2" },
                    { 5, "Защо простото вещество Na се държи под петрол", "За да не взаимодейства с кислорода от въздуха" },
                    { 6, "Кое от химичните съединения на натрия е по-познато в практиката като сода каустик?", "NaOH" },
                    { 7, "С какъв пламък изгаря Na?", "Жълт" },
                    { 8, "Кое от химичните съединения на Na се получава от реакция с реактива AgNO3?", "NaNO3" },
                    { 9, "При електролитна дисоциация на NaOH се получават: ", "Na+ и OH-" },
                    { 10, "От коя валентност е Na?", "1" },
                    { 11, "Ако в разтвор от NaOH внесем лакмус, то той се оцветява: ", "В синьо" },
                    { 12, "Кое от следните прости вещества има по-ниска реактивоспособност от натрия?", "Li" },
                    { 13, "Водният разтвор на NaOH провежда електричен ток.", "Вярно" },
                    { 14, "Според UPAC химичното съединение \"NaH\" се нарича:", "Натриев хидрид" },
                    { 15, "Кое е ГРЕШНОТО твърдение? Натрият / неговите съединения се използват за:", "Промивка след изгаряне" },
                    { 16, "Какъв цвят е простото вещество на Cl?", "Жълто-зелен" },
                    { 17, "Какво се получава при взаимодействието на хлор с водород?", "HCl" },
                    { 18, "Кои киселини се получават при директно взаимодействие на хлор с вода", "HCl и HClO" },
                    { 19, "С кое от веществата хлорът НЕ взаимодейства?", "NaCl" },
                    { 20, "Съединението NaClO се нарича:", "Натриев хипохлорит" },
                    { 21, "От коя група е елементът хлор?", "Седма А" },
                    { 22, "В какъв цвят се оцветява фенолфталеина при контакт с водния разтвор на HCl?", "Не се променя" },
                    { 23, "С какво име в практиката е известен NaClO?", "Белина" },
                    { 24, "От колко атома се състои молекулата на хлора?", "2" },
                    { 25, "В какъв йон се превръща атома на хлора при реакция?", "Отрицателен със заряд 1-" },
                    { 26, "Как се наричат солите на хлора?", "Хлориди" },
                    { 27, "От коя валентност е хлора в съединението си с водорода?", "1" },
                    { 28, "Хипохлористата киселина се разлага до:", "HCl + O" },
                    { 29, "Газът хлор има силен, приятен мирис", "Грешно" },
                    { 30, "За какво се използва хлорът в практиката?", "Дезинфекция на водите" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Title" },
                values: new object[] { 2, "7 клас", "Неметали. Хлор и неговите съединения" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 5, 2, "Неметал" },
                    { 6, 2, "Метал" },
                    { 7, 2, "Нито едно от изброените" },
                    { 8, 2, "Алкалоземен метал" },
                    { 9, 3, "Неметали, киселини, вода" },
                    { 10, 3, "Основни оксиди, киселини, вода" },
                    { 11, 3, "Основи, киселини, метали" },
                    { 12, 3, "Киселинни оксиди, основи, соли" },
                    { 13, 4, "Na2O" },
                    { 14, 4, "Na2O + H2" },
                    { 15, 4, "NaOH + H2" },
                    { 16, 4, "NaOH + H2O" },
                    { 17, 5, "За да не взаимодейства с азота от въздуха" },
                    { 18, 5, "За да не взаимодейства с кислорода от въздуха" },
                    { 19, 5, "За да не отрови въздуха наоколо" },
                    { 20, 5, "За да не се изпари" },
                    { 21, 6, "NaCl" },
                    { 22, 6, "Na2CO3" },
                    { 23, 6, "Na2O2" },
                    { 24, 6, "NaOH" },
                    { 25, 7, "Син" },
                    { 26, 7, "Зелен" },
                    { 27, 7, "Жълт" },
                    { 28, 7, "Виолетов" },
                    { 29, 8, "NaOH" },
                    { 30, 8, "Na2O" },
                    { 31, 8, "NaCl" },
                    { 32, 8, "NaNO3" },
                    { 33, 9, "Na+ и OH-" },
                    { 34, 9, "2Na+ и OH-" },
                    { 35, 9, "Na+ и 2O-" },
                    { 36, 9, "Na+ и OH+" },
                    { 37, 10, "1" },
                    { 38, 10, "2" },
                    { 39, 10, "3" },
                    { 40, 10, "4" },
                    { 41, 11, "В червено" },
                    { 42, 11, "В малиновочервено" },
                    { 43, 11, "В синьо" },
                    { 44, 11, "В жълто" },
                    { 45, 12, "K" },
                    { 46, 12, "Li" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 47, 12, "Rb" },
                    { 48, 12, "Cs" },
                    { 49, 13, "Вярно" },
                    { 50, 13, "Грешно" },
                    { 51, 14, "Натриев хидрид" },
                    { 52, 14, "Натриев хидроксид" },
                    { 53, 14, "Натриев хидрат" },
                    { 54, 14, "Натриев хемоглобин" },
                    { 55, 15, "Приготвяне на физиологичен разтвор" },
                    { 56, 15, "Производство на сапуни" },
                    { 57, 15, "Промивка след изгаряне" },
                    { 58, 15, "Хранително-вкусова промишленост" },
                    { 59, 16, "Червено-кафяв" },
                    { 60, 16, "Виолетов" },
                    { 61, 16, "Бледосин" },
                    { 62, 16, "Жълто-зелен" },
                    { 63, 17, "H2Cl" },
                    { 64, 17, "HCl2" },
                    { 65, 17, "H2Cl2" },
                    { 66, 17, "HCl" },
                    { 67, 18, "HCl и HCl3" },
                    { 68, 18, "HCl и HClO" },
                    { 69, 18, "HCl3 и H3Cl2" },
                    { 70, 18, "HCl2 и HClO" },
                    { 71, 19, "NaCl" },
                    { 72, 19, "NaOH" },
                    { 73, 19, "H2O" },
                    { 74, 19, "H2" },
                    { 75, 20, "Натриев хлорид" },
                    { 76, 20, "Натриев хлорат" },
                    { 77, 20, "Натриев хипохлорид" },
                    { 78, 20, "Натриев хипохлорит" },
                    { 79, 21, "Осма А" },
                    { 80, 21, "Шеста А" },
                    { 81, 21, "Седма А" },
                    { 82, 21, "Пета А" },
                    { 83, 22, "Не се променя" },
                    { 84, 22, "Малиновочервен" },
                    { 85, 22, "Виолетов" },
                    { 86, 22, "Син" },
                    { 87, 23, "Сода каустик" },
                    { 88, 23, "Бертолетова сол" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 89, 23, "Готварска сол" },
                    { 90, 23, "Белина" },
                    { 91, 24, "1" },
                    { 92, 24, "2" },
                    { 93, 24, "3" },
                    { 94, 24, "4" },
                    { 95, 25, "Отрицателен със заряд 1-" },
                    { 96, 25, "Отрицателен със заряд 2-" },
                    { 97, 25, "Положителен със заряд 1+" },
                    { 98, 25, "Положителен със заряд 2+" },
                    { 99, 26, "Перхлорати" },
                    { 100, 26, "Хлорати" },
                    { 101, 26, "Хлорити" },
                    { 102, 26, "Хлориди" },
                    { 103, 27, "1" },
                    { 104, 27, "2" },
                    { 105, 27, "3" },
                    { 106, 27, "4" },
                    { 107, 28, "H + Cl" },
                    { 108, 28, "H2O + Cl2" },
                    { 109, 28, "Cl + OH" },
                    { 110, 28, "HCl + O" },
                    { 111, 29, "Вярно" },
                    { 112, 29, "Грешно" },
                    { 113, 30, "Производство на фойерверки" },
                    { 114, 30, "Дезинфекция на водите" },
                    { 115, 30, "Хранително-вкусовата промишленост" },
                    { 116, 30, "Производство на мебели" }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 16, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 },
                    { 22, 2 },
                    { 23, 2 },
                    { 24, 2 },
                    { 25, 2 },
                    { 26, 2 },
                    { 27, 2 },
                    { 28, 2 },
                    { 29, 2 },
                    { 30, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "В коя група е химичният елемен Na");
        }
    }
}

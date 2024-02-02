using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedNewTests2Again2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                comment: "Answer value",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Answer value");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
                    { 86, "Коя от частиците е с най-малък радиус?", "Al3+" },
                    { 87, "Кое е най-точното определение на \"Електронен облак\"?", "Част от пространството, което е около самото ядро, в която шанса за намиране на електрона е приблизително 90%" },
                    { 88, "Атомните орбитали с едно и също главно и орбитално квантово число образуват електронен слой.", "Грешно" },
                    { 89, "В коя група всички означени вещества са с неполярни молекули?", "CO2, BeH2, N2" },
                    { 90, "Кое от следните твърдения е вярно за масовото число?", "То е равно на сумата от броя на протоните и неутроните" },
                    { 91, "Здравината на ковалентната връзка нараства с увеличаване на нейната кратност", "Вярно" },
                    { 92, "В кой от редовете са изброени само вещества, в които има кратна ковалентна връзка?", "C2H2, N2, CO2" },
                    { 93, "В кой от редовете са изброени само вещества с йонна химична връзка?", "NaH, K2O, BaCl2" },
                    { 94, "π-връзка може да се образува между еднакви по вид атоми", "Вярно" },
                    { 95, "В молекулата на CS2 каква е хибридизацията на централния атом?", "sp" },
                    { 96, "Коя от двойките елементи не се свързва с йонна връзка?", "F и O" },
                    { 97, "Еквивалентните атомни орбитали се заемат първоначално от двойни електрони с паралелни спинове", "Грешно" },
                    { 98, "За веществото X е известно, че има висока температура на топене, ковко е и не се разтваря във вода. Какъв е видът на кристалната решетка на това вещество?", "Метална" },
                    { 99, "На кое от изброените вещества хибридизацията на централния атом е sp^3d^2?", "SF6" },
                    { 100, "Йонизационната енергия характеризира редукционната активност на атомите", "Вярно" },
                    { 101, "Количеството вещество, което съответства на 5.6г азот, е:", "0.2 mol" },
                    { 102, "Кое от твърденията за ендотермични реакции е вярно? При ендотермични реакции:", "Се поглъща топлина, ΔH > 0 и реагентите са по-стабилни" },
                    { 103, "При изгарянето на 9грама алуминий, като знаете че M(Al)=27g/mol, в кислородна среда се отделят 229kJ топлина. Това означава,че стандартната енталпия на образуване на диалуминиевия триоксид е равна на:", "-1374 kJ/mol" },
                    { 104, "Термохимичната функция \"Енергия на Гибс\" се дефинира чрез:", "G = H - T*S" },
                    { 105, "Ентропията расте, когато се преминава от едно по-неподредено към по-подредено състояние", "Грешно" },
                    { 106, "Ако преимем, че реакцията протича по уравнението: S(тв.) + O2(г.) => SO2(г.), то кинетичното уравнение за процеса е:", "v = k * c(O2)" },
                    { 107, "Кинетичното уравнение на химичен процес е v = k * c(A) * c^2(B). Как ще се промени скоростта на процеса при понижаване на налягането два пъти?", "Ще се понижи осем пъти" },
                    { 108, "Ендотермичните процеси не могат да протичат спонтанно", "Грешно" },
                    { 109, "Кое от твърденията не е вярно?", "Ензимите притежават общите свойства на катализаторите" },
                    { 110, "Кое от следните опредления описва \"Вторият закон на Фарадей\"", "За отделянето на един еквивалент от дадено вещество е необходимо през разтвора да преминат 96 500C електричен заряд. Електрохимичният еквивалент се пресмята по формулата: k = M/z*F" },
                    { 111, "При еднаква молна концентрация и температура = const, най-високото осмотично налягане от посочените по долу има ряазтворът на:", "Сярна киселина" },
                    { 112, "При ΔG < 0 реакцията протича спонтанно, а при ΔG = 0 системата се намира в динамично равновесие", "Вярно" },
                    { 113, "При взаимодействие на 1cm^3 1M разтвор на калиев хлорид и 1cm^3 0.1M разтвор на сребърен нитрат е получен зол. Най-бързата коагулация на колоидния разтвор могат да предизвикат:", "Al3+" },
                    { 114, "В коя от групите всички означени вещества оцветяват лакмуса в синьо?", "Ca(OH)2, NH4OH, NaHCO3" },
                    { 115, "Адсорбтив е вещество, което задържа на повърхността си други вещества.", "Грешно" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Title" },
                values: new object[,]
                {
                    { 7, "11-12 клас", "Строеж и свойства на веществата" },
                    { 8, "11-12 клас", "11-12 клас. Обобщителен тест" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 281, 86, "Na+" },
                    { 282, 86, "Ne" },
                    { 283, 86, "Al3+" },
                    { 284, 86, "F-" },
                    { 285, 87, "Състояние, което се определя от стойностите на квантовите числа n, l и m" },
                    { 286, 87, "Функция, която описва електроните в една атомна система" },
                    { 287, 87, "Вероятността за намиране на електрона в простарнството около ядрото" },
                    { 288, 87, "Част от пространството, което е около самото ядро, в която шанса за намиране на електрона е приблизително 90%" },
                    { 289, 88, "Вярно" },
                    { 290, 88, "Грешно" },
                    { 291, 89, "CO2, BeH2, N2" },
                    { 292, 89, "" },
                    { 293, 89, "NH3, H20, N2" },
                    { 294, 89, "H20, CH4, O2" },
                    { 295, 90, "То е сумата от броя на елементарните частици" },
                    { 296, 90, "То е равно на сумата от броя на електроните и неутроните" },
                    { 297, 90, "То е равно на сумата от броя на протоните и неутроните" },
                    { 298, 90, "Според него химичният елемент е смес от изотопи" },
                    { 299, 91, "Вярно" },
                    { 300, 91, "Грешно" },
                    { 301, 92, "CO2, N2, H2O" },
                    { 302, 92, "H2O, CO2, N2" },
                    { 303, 92, "PCl3, H2O, C2H6" },
                    { 304, 92, "C2H2, N2, CO2" },
                    { 305, 93, "CaH2, PCl5, H2S" },
                    { 306, 93, "NH3, AgCl, CH4" },
                    { 307, 93, "NaH, K2O, BaCl2" },
                    { 308, 93, "H2O, H2SO4, HCl" },
                    { 309, 94, "Вярно" },
                    { 310, 94, "Грешно" },
                    { 311, 95, "sp" },
                    { 312, 95, "sp^3d" },
                    { 313, 95, "sp3" },
                    { 314, 95, "sp^3d^2" },
                    { 315, 96, "F и Li" },
                    { 316, 96, "Na и F" },
                    { 317, 96, "H и Ca" },
                    { 318, 96, "F и O" },
                    { 319, 97, "Вярно" },
                    { 320, 97, "Грешно" },
                    { 321, 98, "Метална" },
                    { 322, 98, "Атомна" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 323, 98, "Молекулна" },
                    { 324, 98, "Йонна" },
                    { 325, 99, "PCl5" },
                    { 326, 99, "CO2" },
                    { 327, 99, "SF6" },
                    { 328, 99, "H2O" },
                    { 329, 100, "Вярно" },
                    { 330, 100, "Грешно" },
                    { 331, 101, "0.8 mol" },
                    { 332, 101, "0.2 mol" },
                    { 333, 101, "6.0 mol" },
                    { 334, 101, "2.0 mol" },
                    { 335, 102, "Се поглъща топлина, ΔH < 0 и продуктите са по-стабилни" },
                    { 336, 102, "Се отделя топлина, ΔH < 0 и продуктите са по-стабилни" },
                    { 337, 102, "Се отделя топлина, ΔH > 0 и реагентите са по-стабилни" },
                    { 338, 102, "Се поглъща топлина, ΔH > 0 и реагентите са по-стабилни" },
                    { 339, 103, "-1374 kJ/mol" },
                    { 340, 103, "837 kJ/mol" },
                    { 341, 103, "-837 kJ/mol" },
                    { 342, 103, "1374 kJ/mol" },
                    { 343, 104, "F = U - T*S" },
                    { 344, 104, "H = U + p*V" },
                    { 345, 104, "S = R * lnW" },
                    { 346, 104, "G = H - T*S" },
                    { 347, 105, "Вярно" },
                    { 348, 105, "Грешно" },
                    { 349, 106, "v = k * c(S) * c(O2)" },
                    { 350, 106, "v = k * c^2(O2)" },
                    { 351, 106, "v = k * c(O2)" },
                    { 352, 106, "v = k * c(S)" },
                    { 353, 107, "Ще се понижи два пъти" },
                    { 354, 107, "Ще се понижи шест пъти" },
                    { 355, 107, "Ще се понижи четири пъти" },
                    { 356, 107, "Ще се понижи осем пъти" },
                    { 357, 108, "Вярно" },
                    { 358, 108, "Грешно" },
                    { 359, 109, "Ензимите се отличават от химичните катализатори по своята чувствителност и специфичност" },
                    { 360, 109, "Скоростта на ензимно-каталитичните процеси не зависи от концентрацията на ензима" },
                    { 361, 109, "Ензимите притежават общите свойства на катализаторите" },
                    { 362, 109, "Върху ензимната активност оказва влияние температурата" },
                    { 363, 110, "За отделянето на един еквивалент от дадено вещество е необходимо през разтвора да преминат 96 500C електричен заряд. Електрохимичният еквивалент се пресмята по формулата: k = M/z*F" },
                    { 364, 110, "Масата на веществото m, което се отделя на електродите, е правопропорционална на големината на тока, протекъл през електролита, и времето, за което протича: m = k*I*t" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 365, 110, "За отделянето на един еквивалент от дадено вещество е необходимо през разтвора да преминат 96 500C електричен заряд. Електрохимичният еквивалент се пресмята по формулата: k = M/F" },
                    { 366, 110, "Нито едно от изброените" },
                    { 367, 111, "Готварска сол" },
                    { 368, 111, "Етанол" },
                    { 369, 111, "Калиева основа" },
                    { 370, 111, "Сярна киселина" },
                    { 371, 112, "Вярно" },
                    { 372, 112, "Грешно" },
                    { 373, 113, "Ca2+" },
                    { 374, 113, "S2-" },
                    { 375, 113, "Na+" },
                    { 376, 113, "Al3+" },
                    { 377, 114, "CH3COOK, Na2S, C2H5OH" },
                    { 378, 114, "AlCl3, C6H5OH, H2SO4" },
                    { 379, 114, "KOH, K2CO3, K2SO4" },
                    { 380, 114, "Ca(OH)2, NH4OH, NaHCO3" },
                    { 381, 115, "Вярно" },
                    { 382, 115, "Грешно" }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 86, 7 },
                    { 87, 7 },
                    { 88, 7 },
                    { 89, 7 },
                    { 90, 7 },
                    { 91, 7 },
                    { 92, 7 },
                    { 93, 7 },
                    { 94, 7 },
                    { 95, 7 },
                    { 96, 7 },
                    { 97, 7 },
                    { 98, 7 },
                    { 99, 7 },
                    { 100, 7 },
                    { 101, 8 },
                    { 102, 8 },
                    { 103, 8 },
                    { 104, 8 },
                    { 105, 8 },
                    { 106, 8 },
                    { 107, 8 },
                    { 108, 8 },
                    { 109, 8 }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 110, 8 },
                    { 111, 8 },
                    { 112, 8 },
                    { 113, 8 },
                    { 114, 8 },
                    { 115, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 86, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 87, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 88, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 89, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 90, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 91, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 92, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 93, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 94, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 95, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 96, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 97, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 98, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 99, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 100, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 101, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 102, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 103, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 104, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 105, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 106, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 107, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 108, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 109, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 110, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 111, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 112, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 113, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 114, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 115, 8 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Answer value",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldComment: "Answer value");
        }
    }
}

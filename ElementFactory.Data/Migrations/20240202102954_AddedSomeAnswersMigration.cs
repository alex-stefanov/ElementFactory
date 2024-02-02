using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedSomeAnswersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 232,
                column: "Value",
                value: "\"В разтвор с ниска концентрация се разтваря вещество с висока концентрация\"");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 234,
                column: "Value",
                value: "\"Всеки разтвор е смес от вода и друго вещество с по-висока концентрация\"");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 239,
                column: "Value",
                value: "Солватация, дифузия, разграждане на кристалната решетка (ако има такава)");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 240,
                column: "Value",
                value: "Разграждане на кристалната решетка (ако има такава), солватация, дифузия");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 241,
                column: "Value",
                value: "Дифузия, разграждане на кристалната решетка (ако има такава), солватация");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 242,
                column: "Value",
                value: "Разграждане на кристалната решетка (ако има такава), дифузия, солватация");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 287,
                column: "Value",
                value: "Вероятността за намиране на електрона в пространството около ядрото");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 288,
                column: "Value",
                value: "Част от пространството, което е около самото ядро, в която шансът за намиране на електрона е приблизително 90%");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 292,
                column: "Value",
                value: "HBr, CO2, N2");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 293,
                column: "Value",
                value: "NH3, H2О, N2");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 294,
                column: "Value",
                value: "H2О, CH4, O2");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 335,
                column: "Value",
                value: "се поглъща топлина, ΔH < 0 и продуктите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 336,
                column: "Value",
                value: "се отделя топлина, ΔH < 0 и продуктите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 337,
                column: "Value",
                value: "се отделя топлина, ΔH > 0 и реагентите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 338,
                column: "Value",
                value: "се поглъща топлина, ΔH > 0 и реагентите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 74,
                column: "RightAnswer",
                value: "Разграждане на кристалната решетка (ако има такава), солватация, дифузия");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "Как се нарича обратната реакция на разтварянето, ако е погледнато като обратим проес?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "По коя от формулите НЕ можем да определим концентрацията на даден разтвор?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Description",
                value: "Разтворите са устойчиви системи, чиито размери на частиците НЕ надвишават:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "Процесът на кристализация е съпроводен с положителен топлинен ефект (+Q1).");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Description",
                value: "Ако имаме една кръвна клетка, на която цитозолът е с концентрация 0.9%, а кръвта около нея е с концентрация, по-висока от 1.2%, то спрямо клетката разтворът в околната среда (кръвта) ще бъде:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Какви видове разтвори има според степента на електролитна дисоциация?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "Коя от частиците е с най-малък атомен радиус?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 91,
                column: "Description",
                value: "Здравината на ковалентната връзка нараства с увеличаване на нейната кратност.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 94,
                column: "Description",
                value: "π-връзка може да се образува между еднакви по вид атоми.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 97,
                column: "Description",
                value: "Еквивалентните атомни орбитали се заемат първоначално от двойни електрони с паралелни спинове.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 100,
                column: "Description",
                value: "Йонизационната енергия характеризира редукционната активност на атомите.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 102,
                column: "RightAnswer",
                value: "се поглъща топлина, ΔH > 0 и реагентите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 103,
                column: "Description",
                value: "При изгарянето на 9 грама алуминий, като знаете че M(Al) = 27g/mol, в кислородна среда се отделят 229kJ топлина. Това означава, че стандартната енталпия на образуване на диалуминиевия триоксид е равна на:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 105,
                column: "Description",
                value: "Ентропията расте, когато се преминава от едно по-неподредено към по-подредено състояние.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 106,
                column: "Description",
                value: "Ако приемем, че реакцията протича по уравнението: S(тв.) + O2(г.) => SO2(г.), то кинетичното уравнение за процеса е:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 108,
                column: "Description",
                value: "Ендотермичните процеси не могат да протичат спонтанно.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 109,
                column: "Description",
                value: "Кое от твърденията НЕ е вярно?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Кое от следните определения описва \"Вторият закон на Фарадей\"");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "При еднаква молна концентрация и температура = const, най-високото осмотично налягане от посочените по-долу има разтворът на:");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 232,
                column: "Value",
                value: "\"В разтвор с ниска концетрация се разтваря вещество с висока концетрация\"");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 234,
                column: "Value",
                value: "\"Всеки разтвор е смес от вода и друго вещество с по-висока концентеация\"");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 239,
                column: "Value",
                value: "Солватация, дифузия, разграждане на кристалната решетка(ако има такава)");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 240,
                column: "Value",
                value: "Разграждане на кристалната решетка(ако има такава), солватация, дифузия");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 241,
                column: "Value",
                value: "Дифузия, разграждане на кристалната решетка(ако има такава), солватация");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 242,
                column: "Value",
                value: "Разграждане на кристалната решетка(ако има такава), дифузия, солватация");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 287,
                column: "Value",
                value: "Вероятността за намиране на електрона в простарнството около ядрото");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 288,
                column: "Value",
                value: "Част от пространството, което е около самото ядро, в която шанса за намиране на електрона е приблизително 90%");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 292,
                column: "Value",
                value: "");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 293,
                column: "Value",
                value: "NH3, H20, N2");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 294,
                column: "Value",
                value: "H20, CH4, O2");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 335,
                column: "Value",
                value: "Се поглъща топлина, ΔH < 0 и продуктите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 336,
                column: "Value",
                value: "Се отделя топлина, ΔH < 0 и продуктите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 337,
                column: "Value",
                value: "Се отделя топлина, ΔH > 0 и реагентите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 338,
                column: "Value",
                value: "Се поглъща топлина, ΔH > 0 и реагентите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 74,
                column: "RightAnswer",
                value: "Разграждане на кристалната решетка(ако има такава), солватация, дифузия");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "Как се нарича обратната реакция на разтварянето ако е погледнато като обратим проес?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "По коя от формулите не можем да определим концентрацията на даден разтвор?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Description",
                value: "Разтворите са устойчиви системи, чиито размери на частиците не надвишават:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "Процесът на кристализация е проведен с положителен топлинен ефект(+Q1)");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Description",
                value: "Ако имаме една кръвна,на която цитозолата е с концетрация 0.9%, а кръвта около нея е с концентрация по-висока от 1.2%, то спрямо клетката, разтвора в околната среда(кръвта) ще бъде:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Какви видове разтвори има според степнта на електролитна дисоциация?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "Коя от частиците е с най-малък радиус?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 91,
                column: "Description",
                value: "Здравината на ковалентната връзка нараства с увеличаване на нейната кратност");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 94,
                column: "Description",
                value: "π-връзка може да се образува между еднакви по вид атоми");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 97,
                column: "Description",
                value: "Еквивалентните атомни орбитали се заемат първоначално от двойни електрони с паралелни спинове");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 100,
                column: "Description",
                value: "Йонизационната енергия характеризира редукционната активност на атомите");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 102,
                column: "RightAnswer",
                value: "Се поглъща топлина, ΔH > 0 и реагентите са по-стабилни");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 103,
                column: "Description",
                value: "При изгарянето на 9грама алуминий, като знаете че M(Al)=27g/mol, в кислородна среда се отделят 229kJ топлина. Това означава,че стандартната енталпия на образуване на диалуминиевия триоксид е равна на:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 105,
                column: "Description",
                value: "Ентропията расте, когато се преминава от едно по-неподредено към по-подредено състояние");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 106,
                column: "Description",
                value: "Ако преимем, че реакцията протича по уравнението: S(тв.) + O2(г.) => SO2(г.), то кинетичното уравнение за процеса е:");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 108,
                column: "Description",
                value: "Ендотермичните процеси не могат да протичат спонтанно");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 109,
                column: "Description",
                value: "Кое от твърденията не е вярно?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Кое от следните опредления описва \"Вторият закон на Фарадей\"");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "При еднаква молна концентрация и температура = const, най-високото осмотично налягане от посочените по долу има ряазтворът на:");
        }
    }
}

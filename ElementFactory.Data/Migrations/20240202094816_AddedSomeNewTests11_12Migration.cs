using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedSomeNewTests11_12Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tests",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Test title",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Tests",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Test category",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tests",
                type: "int",
                nullable: false,
                comment: "Test identificator",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "TestId",
                table: "QuestionsTests",
                type: "int",
                nullable: false,
                comment: "Test identificator",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "QuestionsTests",
                type: "int",
                nullable: false,
                comment: "Question identificator",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RightAnswer",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Question right answer",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Questions",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                comment: "Question description",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Questions",
                type: "int",
                nullable: false,
                comment: "Question identificator",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ChemicalElementSymbol",
                table: "FoundersChemicalElements",
                type: "nvarchar(2)",
                nullable: false,
                comment: "Chemical element symbol => PK",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)");

            migrationBuilder.AlterColumn<int>(
                name: "FounderId",
                table: "FoundersChemicalElements",
                type: "int",
                nullable: false,
                comment: "Founder identificator",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Founders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Founder last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Founders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Founder first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Founders",
                type: "int",
                nullable: false,
                comment: "Founder identificator",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "Chemical type name *english*",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "BulgarianName",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "Chemical type name *bulgarian*",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ChemicalTypes",
                type: "int",
                nullable: false,
                comment: "Chemical Type identificator",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "YearFound",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                comment: "Chemical element year when found",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "ChemicalElements",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Chemical element state *english*",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "Period",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                comment: "Chemical element period",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalElements",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "Chemical element name *bulgarian*",
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<decimal>(
                name: "MeltingPoint",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Chemical element melting point",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSynthetic",
                table: "ChemicalElements",
                type: "bit",
                nullable: false,
                comment: "Is chemical element synthetic - flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRadioactive",
                table: "ChemicalElements",
                type: "bit",
                nullable: false,
                comment: "Is chemical element radioactive - flag",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Group",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                comment: "Chemical element group",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EnglishName",
                table: "ChemicalElements",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "Chemical element name *english*",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ElectronicLayers",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                comment: "Chemical element electronic layers",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Electronegativity",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Chemical element electronegativity",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Density",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Chemical element density",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "ChemicalTypeId",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                comment: "Chemical element id for type",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BulgarianState",
                table: "ChemicalElements",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Chemical element state *bulgarian*",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<decimal>(
                name: "BoilingPoint",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Chemical element boiling point",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AtomicRadius",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Chemical element atomic radius",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "AtomicNumber",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                comment: "Chemical element atomic number",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "AtomicMass",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Chemical element atomic mass",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "ChemicalElements",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                comment: "Chemical element symbol => PK",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Answer value",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: false,
                comment: "Answer question Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Answers",
                type: "int",
                nullable: false,
                comment: "Answer identificator",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Value",
                value: "Неметали, киселини, вода");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Value",
                value: "Основни оксиди, киселини, вода");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Value",
                value: "Основи, киселини, метали");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: "Киселинни оксиди, основи, соли");

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
                keyValue: 5,
                column: "Description",
                value: "Защо простото вещество Na се държи под петрол");

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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
                    { 61, "Топлината на образуване на 1 мол хлороводор е 92.5kJ.Какъв е топлинният ефект на реакцията: H + Cl => HCl (Уравнението не е изравнено!) в kJ?", "185" },
                    { 62, "Колко е температурата на образуване на ромбичната сяра в kJ?", "0" },
                    { 63, "Изчислете топлината на образуване на NH3 според уравнението в kJ закръглено до първия знак след запетаята.N2 + 3H2 => 2NH3 + 92,4 kJ", "46.2" },
                    { 64, "Ако температурата на образуване на водните пари е 242.5kJ, то тогава колко е температурата им на изгаряне сметната в kJ и закръглена до първия знак след запетаята?", "-242.5" },
                    { 65, "Ако температурата на образуване на графита е 394.8kJ/mol, а на диаманта е 396.6kJ/mol, то тогава колко ще бъде топлинният ефект при реакция от вида \"графит=>диамант\" измерена в kJ и закръглена до първия знак след запетаята?.", "-1.8" },
                    { 66, "Дадено:\r\nC6H6 + 15/2 O2 => 6CO2 + 3H20 + Q\r\nQ=3271kJ\r\nQобразуване(CO2)=394kJ/mol\r\nQобразуване(H20)=285.8kJ/mol\r\nТърсим:\r\nQобразуване(C6H6)=?kJ закръглено до първия знак след запетаята", "-49.6" },
                    { 67, "Ако в хомогенният едностадиен процес 2CO + O2 => 2CO2, концентрацията на CO се увеличи 3 пъти при t=const то с колко пъти новата скорост ще е по-голяма от старата", "9" },
                    { 68, "2SO2(г) + O2(г) => 2SO3(г) + Q. Ако увеличим налягането на системата три пъти, то с колко новата средна скорост на уравнението ще бъде по-голямата от тази на началното уравнение", "27" },
                    { 69, "S(тв) + H2(г) => H2S(г) + 4.8kJ. Изчислете количеството обменена топлина в kJ, закръглено до първия знак след запетаята, ако 8грама сяра реагират по даденото химияно уравнение(счита се,че M(S)=32.0)", "1.2" },
                    { 70, "Колко е температурата на изгаряне на SO3 в kJ/mol?", "0" },
                    { 71, "Кои са задължителните компоненти на истинските разтвори?", "Разтворител и разтварящо се вещество" },
                    { 72, "По кое правило/закон се образуват разтворите?", "\"Подобни се разтварят в подобни\"" },
                    { 73, "Според частиците на разтвореното вещество, разтворите биват:", "Молекулни и йонни" },
                    { 74, "Коя е правилната последователност на процесите, през които минава механизмът на разтварянето?", "Разграждане на кристалната решетка(ако има такава), солватация, дифузия" },
                    { 75, "Как се нарича обратната реакция на разтварянето ако е погледнато като обратим проес?", "Кристализация" },
                    { 76, "Видовете разтвори според състоянието им от състоянието на равновесие са само наситен и ненаситен.", "Грешно" },
                    { 77, "По коя от формулите не можем да определим концентрацията на даден разтвор?", "m(р-р) = M(А) * n(р-р)" },
                    { 78, "Разтворите са устойчиви системи, чиито размери на частиците не надвишават:", "1 нанометър" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
                    { 79, "Процесът на кристализация е проведен с положителен топлинен ефект(+Q1)", "Грешно" },
                    { 80, "На кой ред са изброени всички общи свойства на разтворите?", "Понижаването на температурата на замръзване, повишаването на температурата на кипене, дифузия, понижаване на парното налягане, осмоза" },
                    { 81, "Коя е най-точната формула за определяне на осмотичното налягане?", "π = i*c*R*T" },
                    { 82, "Ако имаме една кръвна,на която цитозолата е с концетрация 0.9%, а кръвта около нея е с концентрация по-висока от 1.2%, то спрямо клетката, разтвора в околната среда(кръвта) ще бъде:", "Хипертоничен" },
                    { 83, "На кой ред всички изброени вещества са електролити?", "CuSO4, NaOH, H2O, Ca(OH)2" },
                    { 84, "Какви видове разтвори има според степнта на електролитна дисоциация?", "Средни, слаби, силни" },
                    { 85, "Водата е електролит.", "Вярно" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Title" },
                values: new object[,]
                {
                    { 5, "10 клас", "Характеристики на химичните процеси" },
                    { 6, "10 клас", "Разтвори и химични процеси във водни разтвори" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 227, 71, "Вода и разтварящо се вещество" },
                    { 228, 71, "Течен разтворител и захар" },
                    { 229, 71, "Разтворител и разтварящо се вещество" },
                    { 230, 71, "Нито едно от изброените" },
                    { 231, 72, "\"Йони се разтварят в йони\"" },
                    { 232, 72, "\"В разтвор с ниска концетрация се разтваря вещество с висока концетрация\"" },
                    { 233, 72, "\"Подобни се разтварят в подобни\"" },
                    { 234, 72, "\"Всеки разтвор е смес от вода и друго вещество с по-висока концентеация\"" },
                    { 235, 73, "Молекулни и йонни" },
                    { 236, 73, "Течни и твърди" },
                    { 237, 73, "Соли, основи и киселини" },
                    { 238, 73, "Според частиците на разтвореното вещество не се разглеждат различни по видове разтвори" },
                    { 239, 74, "Солватация, дифузия, разграждане на кристалната решетка(ако има такава)" },
                    { 240, 74, "Разграждане на кристалната решетка(ако има такава), солватация, дифузия" },
                    { 241, 74, "Дифузия, разграждане на кристалната решетка(ако има такава), солватация" },
                    { 242, 74, "Разграждане на кристалната решетка(ако има такава), дифузия, солватация" },
                    { 243, 75, "Йонизация" },
                    { 244, 75, "Солватация" },
                    { 245, 75, "Дифузия" },
                    { 246, 75, "Кристализация" },
                    { 247, 76, "Вярно" },
                    { 248, 76, "Грешно" },
                    { 249, 77, "m(р-р) = M(А) * n(р-р)" },
                    { 250, 77, "S(А) = m(А) / 100g(р-р)" },
                    { 251, 77, "W(А) = m(А) / m(р-р)" },
                    { 252, 77, "C(А) = n(А) / V" },
                    { 253, 78, "1 милиметър" },
                    { 254, 78, "1 нанометър" },
                    { 255, 78, "1 микрон" },
                    { 256, 78, "1 метър" },
                    { 257, 79, "Вярно" },
                    { 258, 79, "Грешно" },
                    { 259, 80, "Дифузия, понижаване на парното налягане, осмоза" },
                    { 260, 80, "Повишаването на температурата на замръзване, понижаването на температурата на кипене, дифузия, понижаване на парното налягане, осмоза" },
                    { 261, 80, "Понижаването на температурата на замръзване, повишаването на температурата на кипене, дифузия, понижаване на парното налягане, осмоза" },
                    { 262, 80, "Дифузия, повишаване на парното налягане, осмоза" },
                    { 263, 81, "π = 3*i*c*R" },
                    { 264, 81, "π = i*c*R*T" },
                    { 265, 81, "2*π = i*c*R*T" },
                    { 266, 81, "π^2 = i*c*R*T" },
                    { 267, 82, "Хипертоничен" },
                    { 268, 82, "Хипотоничен" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 269, 82, "Изотоничен" },
                    { 270, 82, "Разтвор на електролит" },
                    { 271, 83, "C6H12O6, Cl2, Al(OH)3, Na2CO3" },
                    { 272, 83, "AlCl3, захар, Sr(OH)2, NaCl" },
                    { 273, 83, "C6H6, S, KOH, CaCO3" },
                    { 274, 83, "CuSO4, NaOH, H2O, Ca(OH)2" },
                    { 275, 84, "Наситени, преситени, ненаситени" },
                    { 276, 84, "Силни и слаби" },
                    { 277, 84, "Средни, слаби, силни" },
                    { 278, 84, "Електролитни и неелектролитни" },
                    { 279, 85, "Вярно" },
                    { 280, 85, "Грешно" }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 61, 5 },
                    { 62, 5 },
                    { 63, 5 },
                    { 64, 5 },
                    { 65, 5 },
                    { 66, 5 },
                    { 67, 5 },
                    { 68, 5 },
                    { 69, 5 },
                    { 70, 5 },
                    { 71, 6 },
                    { 72, 6 },
                    { 73, 6 },
                    { 74, 6 },
                    { 75, 6 },
                    { 76, 6 },
                    { 77, 6 },
                    { 78, 6 },
                    { 79, 6 },
                    { 80, 6 },
                    { 81, 6 },
                    { 82, 6 },
                    { 83, 6 },
                    { 84, 6 },
                    { 85, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 61, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 62, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 63, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 64, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 65, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 66, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 67, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 68, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 69, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 70, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 71, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 72, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 73, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 74, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 75, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 76, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 77, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 78, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 79, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 80, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 81, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 82, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 83, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 84, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionsTests",
                keyColumns: new[] { "QuestionId", "TestId" },
                keyValues: new object[] { 85, 6 });

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tests",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Test title");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Tests",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Test category");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Test identificator")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "TestId",
                table: "QuestionsTests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Test identificator");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "QuestionsTests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Question identificator");

            migrationBuilder.AlterColumn<string>(
                name: "RightAnswer",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Question right answer");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Questions",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldComment: "Question description");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Questions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Question identificator")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ChemicalElementSymbol",
                table: "FoundersChemicalElements",
                type: "nvarchar(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldComment: "Chemical element symbol => PK");

            migrationBuilder.AlterColumn<int>(
                name: "FounderId",
                table: "FoundersChemicalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Founder identificator");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Founders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Founder last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Founders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Founder first name");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Founders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Founder identificator")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldComment: "Chemical type name *english*");

            migrationBuilder.AlterColumn<string>(
                name: "BulgarianName",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldComment: "Chemical type name *bulgarian*");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ChemicalTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Chemical Type identificator")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "YearFound",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Chemical element year when found");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "ChemicalElements",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Chemical element state *english*");

            migrationBuilder.AlterColumn<int>(
                name: "Period",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Chemical element period");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalElements",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "Chemical element name *bulgarian*");

            migrationBuilder.AlterColumn<decimal>(
                name: "MeltingPoint",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Chemical element melting point");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSynthetic",
                table: "ChemicalElements",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Is chemical element synthetic - flag");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRadioactive",
                table: "ChemicalElements",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Is chemical element radioactive - flag");

            migrationBuilder.AlterColumn<int>(
                name: "Group",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Chemical element group");

            migrationBuilder.AlterColumn<string>(
                name: "EnglishName",
                table: "ChemicalElements",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "Chemical element name *english*");

            migrationBuilder.AlterColumn<int>(
                name: "ElectronicLayers",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Chemical element electronic layers");

            migrationBuilder.AlterColumn<decimal>(
                name: "Electronegativity",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Chemical element electronegativity");

            migrationBuilder.AlterColumn<decimal>(
                name: "Density",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Chemical element density");

            migrationBuilder.AlterColumn<int>(
                name: "ChemicalTypeId",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Chemical element id for type");

            migrationBuilder.AlterColumn<string>(
                name: "BulgarianState",
                table: "ChemicalElements",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Chemical element state *bulgarian*");

            migrationBuilder.AlterColumn<decimal>(
                name: "BoilingPoint",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Chemical element boiling point");

            migrationBuilder.AlterColumn<decimal>(
                name: "AtomicRadius",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Chemical element atomic radius");

            migrationBuilder.AlterColumn<int>(
                name: "AtomicNumber",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Chemical element atomic number");

            migrationBuilder.AlterColumn<decimal>(
                name: "AtomicMass",
                table: "ChemicalElements",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Chemical element atomic mass");

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "ChemicalElements",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldComment: "Chemical element symbol => PK");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Answer value");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Answer question Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Answers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Answer identificator")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Value",
                value: "Неметали, киселини и вода");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Value",
                value: "Основни оксиди, киселини и вода");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Value",
                value: "Основи, киселини и метали");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: "Киселинни оксиди, основи и соли");

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
                keyValue: 5,
                column: "Description",
                value: "Защо простото вещество Na се държи под петрол?");

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
                value: "Реакцията \"Гасене на вар\" е реакция на CaO с вода, при коятo се получава/т:");

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
                value: "Какъв е цветът на пламъка при горенето на Ca?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "Разтворът на Ca(OH)2 е с pH:");

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
    }
}

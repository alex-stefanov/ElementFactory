using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class AddedJSONConfMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "Chemical type name english");

            migrationBuilder.AddColumn<string>(
                name: "BulgarianName",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "Chemical type name bulgarian");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ChemicalElements",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.InsertData(
                table: "ChemicalTypes",
                columns: new[] { "Id", "BulgarianName", "Name" },
                values: new object[,]
                {
                    { 1, "Неметал", "Non-Metal" },
                    { 2, "Алкален метал", "Alkali Metal" },
                    { 3, "Алкалоземен метал", "Alkaline Earth Metal" },
                    { 4, "Преходен метал", "Transition Metal" },
                    { 5, "Други метали", "PostTransition Metal" },
                    { 6, "Халоген", "Halogen" },
                    { 7, "Благороден газ", "Noble gas" },
                    { 8, "Лантанид", "Lanthanide" },
                    { 9, "Актинид", "Actinide" },
                    { 10, "Металоид", "Metaloid" }
                });

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

            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Symbol", "AtomicMass", "AtomicNumber", "AtomicRadius", "BoilingPoint", "BulgarianState", "ChemicalTypeId", "Density", "Electronegativity", "ElectronicLayers", "EnglishName", "Group", "Id", "IsRadioactive", "IsSynthetic", "MeltingPoint", "Name", "Period", "State", "YearFound" },
                values: new object[,]
                {
                    { "Ac", 227.03m, 89, 260.00m, 3500.00m, "Твърдо вещество", 9, 10.00m, 1.10m, 7, "Actinium", 0, 97, true, false, 1500.00m, "Актиний", 7, "Solid", 1902 },
                    { "Ag", 107.87m, 47, 172.00m, 2435.00m, "Твърдо вещество", 4, 10.49m, 1.93m, 5, "Silver", 11, 20, false, false, 1234.93m, "Сребро", 5, "Solid", 0 },
                    { "Al", 26.98m, 13, 184.00m, 2743.00m, "Твърдо вещество", 5, 2.70m, 1.61m, 3, "Aluminium", 13, 58, false, false, 933.47m, "Алуминий", 3, "Solid", 1824 },
                    { "Am", 243.06m, 95, 244.00m, 2880.00m, "Твърдо вещество", 9, 12.00m, 1.30m, 7, "Americium", 0, 98, true, true, 1449.00m, "Амерций", 7, "Solid", 1944 },
                    { "Ar", 39.90m, 18, 188.00m, 87.30m, "Газ", 7, 1.78m, 0.00m, 3, "Argon", 18, 75, false, false, 83.81m, "Аргон", 3, "Gas", 1894 },
                    { "As", 74.92m, 33, 185.00m, 887.00m, "Твърдо вещество", 10, 5.73m, 2.18m, 4, "Arsenic", 15, 112, false, false, 1090.00m, "Арсен", 4, "Solid", 0 },
                    { "At", 209.99m, 85, 202.00m, 0.00m, "Твърдо вещество", 6, 8.91m, 0.00m, 6, "Astatine", 17, 69, true, false, 575.00m, "Астат", 6, "Solid", 1940 },
                    { "Au", 196.97m, 79, 166.00m, 3243.00m, "Твърдо вещество", 4, 19.30m, 2.54m, 6, "Gold", 11, 21, false, false, 1337.33m, "Злато", 6, "Solid", 0 },
                    { "B", 10.81m, 5, 192.00m, 4200.00m, "Твърдо вещество", 10, 2.08m, 2.04m, 2, "Boron", 13, 113, false, false, 2349.00m, "Бор", 2, "Solid", 1808 },
                    { "Ba", 137.33m, 56, 268.00m, 2118.00m, "Твърдо вещество", 3, 3.51m, 0.89m, 6, "Barium", 2, 14, false, false, 1000.00m, "Барий", 6, "Solid", 1772 },
                    { "Be", 9.01m, 4, 153.00m, 2742.00m, "Твърдо вещество", 3, 1.85m, 1.57m, 2, "Beryllium", 2, 15, false, false, 1560.00m, "Берилий", 2, "Solid", 1798 },
                    { "Bh", 270.13m, 107, 0.00m, 0.00m, "Твърдо вещество", 4, 26.00m, 0.00m, 7, "Bohrium", 7, 22, true, true, 0.00m, "Борий", 7, "Solid", 1981 },
                    { "Bi", 208.98m, 83, 207.00m, 1837.00m, "Твърдо вещество", 5, 9.78m, 2.02m, 6, "Bismuth", 15, 59, false, false, 544.70m, "Бисмут", 6, "Solid", 0 },
                    { "Bk", 247.07m, 97, 244.00m, 2900.00m, "Твърдо вещество", 9, 14.78m, 1.30m, 7, "Berkelium", 0, 99, true, true, 1259.00m, "Берклий", 7, "Solid", 1949 },
                    { "Br", 79.90m, 35, 183.00m, 332.00m, "Течност", 6, 3.10m, 2.96m, 4, "Bromine", 17, 70, false, false, 265.80m, "Бром", 4, "Liquid", 1825 },
                    { "C", 12.01m, 6, 170.00m, 4098.00m, "Твърдо вещество", 1, 2.27m, 2.55m, 2, "Carbon", 14, 1, false, false, 3823.00m, "Въглерод", 2, "Solid", 0 },
                    { "Ca", 40.08m, 20, 231.00m, 1757.00m, "Твърдо вещество", 3, 1.55m, 1.00m, 4, "Calcium", 2, 16, false, false, 1115.00m, "Калций", 4, "Solid", 0 },
                    { "Cd", 112.41m, 48, 158.00m, 1040.00m, "Твърдо вещество", 4, 8.65m, 1.69m, 5, "Cadmium", 12, 23, false, false, 594.22m, "Кадмий", 5, "Solid", 1817 },
                    { "Ce", 140.12m, 58, 235.00m, 3716.00m, "Твърдо вещество", 8, 6.77m, 1.12m, 6, "Cerium", 0, 82, false, false, 1068.00m, "Церий", 6, "Solid", 1803 },
                    { "Cf", 251.08m, 98, 245.00m, 1743.00m, "Твърдо вещество", 9, 15.10m, 1.30m, 7, "Californium", 0, 100, true, true, 1173.00m, "Калифорний", 7, "Solid", 1950 },
                    { "Cl", 35.45m, 17, 175.00m, 239.11m, "Газ", 6, 3.20m, 3.16m, 3, "Chlorine", 17, 71, false, false, 171.60m, "Хлор", 3, "Gas", 1774 },
                    { "Cm", 247.07m, 96, 245.00m, 3383.00m, "Твърдо вещество", 9, 13.51m, 1.30m, 7, "Curium", 0, 101, true, true, 1613.00m, "Кюрий", 7, "Solid", 1944 },
                    { "Cn", 286.18m, 112, 0.00m, 0.00m, "Неопределено", 4, 14.00m, 0.00m, 7, "Copernicium", 12, 24, true, true, 0.00m, "Коперниций", 7, "NA", 1996 },
                    { "Co", 58.93m, 27, 192.00m, 3200.00m, "Твърдо вещество", 4, 8.90m, 1.88m, 4, "Cobalt", 9, 25, false, false, 1768.00m, "Кобалт", 4, "Solid", 1735 },
                    { "Cr", 52.00m, 24, 189.00m, 2944.00m, "Твърдо вещество", 4, 7.15m, 1.66m, 4, "Chromium", 6, 26, false, false, 2180.00m, "Хром", 4, "Solid", 1797 },
                    { "Cs", 132.91m, 55, 343.00m, 944.00m, "Твърдо вещество", 2, 1.93m, 0.79m, 6, "Caesium", 1, 8, false, false, 301.70m, "Цезий", 6, "Solid", 1860 },
                    { "Cu", 63.55m, 29, 140.00m, 2835.00m, "Твърдо вещество", 4, 8.96m, 1.90m, 4, "Copper", 11, 27, false, false, 1357.77m, "Мед", 4, "Solid", 0 },
                    { "Db", 268.13m, 105, 0.00m, 0.00m, "Твърдо вещество", 4, 21.60m, 0.00m, 7, "Dubnium", 5, 28, true, true, 0.00m, "Дубний", 7, "Solid", 1970 },
                    { "Ds", 282.17m, 110, 0.00m, 0.00m, "Неопределено", 4, 26.00m, 0.00m, 7, "Darmstadtium", 10, 29, true, true, 0.00m, "Дармщатий", 7, "NA", 1994 },
                    { "Dy", 162.50m, 66, 229.00m, 2840.00m, "Твърдо вещество", 8, 8.54m, 1.22m, 6, "Dysprosium", 0, 83, false, false, 1680.00m, "Диспросий", 6, "Solid", 1886 },
                    { "Er", 167.26m, 68, 235.00m, 3141.00m, "Твърдо вещество", 8, 9.07m, 1.24m, 6, "Erbium", 0, 84, false, false, 1802.00m, "Ербий", 6, "Solid", 1843 },
                    { "Es", 252.08m, 99, 245.00m, 1269.00m, "Твърдо вещество", 9, 8.84m, 1.30m, 7, "Einsteinium", 0, 102, true, true, 1133.00m, "Айнщайний", 7, "Solid", 1952 },
                    { "Eu", 151.96m, 63, 233.00m, 1802.00m, "Твърдо вещество", 8, 5.24m, 1.20m, 6, "Europium", 0, 85, false, false, 1099.00m, "Европий", 6, "Solid", 1901 },
                    { "F", 19.00m, 9, 135.00m, 85.03m, "Газ", 6, 1.70m, 3.98m, 2, "Fluorine", 17, 72, false, false, 53.48m, "Флуор", 2, "Gas", 1810 },
                    { "Fe", 55.84m, 26, 194.00m, 3134.00m, "Твърдо вещество", 4, 7.87m, 1.83m, 4, "Iron", 8, 30, false, false, 1811.00m, "Желязо", 4, "Solid", 0 },
                    { "Fl", 290.19m, 114, 0.00m, 0.00m, "Неопределено", 5, 11.40m, 0.00m, 7, "Flerovium", 14, 60, true, true, 0.00m, "Флеровий", 7, "NA", 1999 },
                    { "Fm", 257.10m, 100, 0.00m, 0.00m, "Твърдо вещество", 9, 9.70m, 1.30m, 7, "Fermium", 0, 103, true, true, 1800.00m, "Фермий", 7, "Solid", 1953 },
                    { "Fr", 223.02m, 87, 348.00m, 950.00m, "Твърдо вещество", 2, 2.48m, 0.79m, 7, "Francium", 1, 9, true, false, 300.00m, "Франций", 7, "Solid", 1939 },
                    { "Ga", 69.72m, 31, 187.00m, 2676.00m, "Твърдо вещество", 5, 5.91m, 1.81m, 4, "Gallium", 13, 61, false, false, 302.91m, "Галий", 4, "Solid", 1875 },
                    { "Gd", 157.20m, 64, 237.00m, 3546.00m, "Твърдо вещество", 8, 7.90m, 1.20m, 6, "Gadolinium", 0, 86, false, false, 1585.00m, "Гадолиний", 6, "Solid", 1880 },
                    { "Ge", 72.63m, 32, 211.00m, 3106.00m, "Твърдо вещество", 10, 5.32m, 2.01m, 4, "Germanium", 14, 114, false, false, 1211.40m, "Германий", 4, "Solid", 1886 },
                    { "H", 1.01m, 1, 120.00m, 20.27m, "Газ", 1, 0.09m, 2.20m, 1, "Hydrogen", 1, 2, false, false, 13.99m, "Водород", 1, "Gas", 1766 }
                });

            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Symbol", "AtomicMass", "AtomicNumber", "AtomicRadius", "BoilingPoint", "BulgarianState", "ChemicalTypeId", "Density", "Electronegativity", "ElectronicLayers", "EnglishName", "Group", "Id", "IsRadioactive", "IsSynthetic", "MeltingPoint", "Name", "Period", "State", "YearFound" },
                values: new object[,]
                {
                    { "He", 4.00m, 2, 140.00m, 4.22m, "Газ", 7, 0.18m, 0.00m, 1, "Helium", 18, 76, false, false, 0.95m, "Хелий", 1, "Gas", 1868 },
                    { "Hf", 178.49m, 72, 212.00m, 4876.00m, "Твърдо вещество", 4, 13.31m, 1.30m, 6, "Hafnium", 4, 31, false, false, 2506.00m, "Хафний", 6, "Solid", 1922 },
                    { "Hg", 200.59m, 80, 209.00m, 629.88m, "Течност", 4, 13.55m, 2.00m, 6, "Mercury", 12, 32, false, false, 234.32m, "Живак", 6, "Liquid", 0 },
                    { "Ho", 164.93m, 67, 216.00m, 2873.00m, "Твърдо вещество", 8, 8.79m, 1.23m, 6, "Holmium", 0, 87, false, false, 1734.00m, "Холмий", 6, "Solid", 1878 },
                    { "Hs", 269.13m, 108, 0.00m, 0.00m, "Твърдо вещество", 4, 27.00m, 0.00m, 7, "Hassium", 8, 33, true, true, 0.00m, "Хасий", 7, "Solid", 1984 },
                    { "I", 126.90m, 53, 198.00m, 457.40m, "Твърдо вещество", 6, 4.93m, 2.66m, 5, "Iodine", 17, 73, false, false, 386.85m, "Йод", 5, "Solid", 1811 },
                    { "In", 114.82m, 49, 193.00m, 2345.00m, "Твърдо вещество", 5, 7.31m, 1.78m, 5, "Indium", 13, 62, false, false, 429.75m, "Индий", 5, "Solid", 1863 },
                    { "Ir", 192.22m, 77, 202.00m, 4403.00m, "Твърдо вещество", 4, 22.56m, 2.20m, 6, "Iridium", 9, 34, false, false, 2719.00m, "Иридий", 6, "Solid", 1803 },
                    { "K", 39.10m, 19, 275.00m, 1030.79m, "Твърдо вещество", 2, 0.89m, 0.82m, 4, "Potassium", 1, 10, false, false, 336.70m, "Калий", 4, "Solid", 1807 },
                    { "Kr", 83.80m, 36, 202.00m, 119.93m, "Газ", 7, 3.75m, 3.00m, 4, "Krypton", 18, 77, false, false, 115.78m, "Криптон", 4, "Gas", 1898 },
                    { "La", 138.91m, 57, 240.00m, 3737.00m, "Твърдо вещество", 8, 6.16m, 1.10m, 6, "Lanthanum", 0, 88, false, false, 1193.00m, "Лантан", 6, "Solid", 1838 },
                    { "Li", 7.00m, 3, 182.00m, 1603.00m, "Твърдо вещество", 2, 0.53m, 0.98m, 2, "Lithium", 1, 11, false, false, 453.65m, "Литий", 2, "Solid", 1817 },
                    { "Lr", 266.12m, 103, 0.00m, 0.00m, "Твърдо вещество", 9, 14.40m, 1.30m, 7, "Lawrencium", 0, 104, true, true, 1900.00m, "Лоуренсий", 7, "Solid", 1961 },
                    { "Lu", 174.97m, 71, 221.00m, 3675.00m, "Твърдо вещество", 8, 9.84m, 1.27m, 6, "Lutetium", 0, 89, false, false, 1925.00m, "Лутеций", 6, "Solid", 1906 },
                    { "Lv", 293.21m, 116, 0.00m, 0.00m, "Неопределено", 5, 12.90m, 0.00m, 7, "Livermorium", 16, 63, true, true, 0.00m, "Ливерморий", 7, "NA", 2000 },
                    { "Mc", 290.20m, 115, 0.00m, 0.00m, "Неопределено", 5, 13.50m, 0.00m, 7, "Moscovium", 15, 64, true, true, 0.00m, "Московий", 7, "NA", 2003 },
                    { "Md", 258.10m, 101, 0.00m, 0.00m, "Твърдо вещество", 9, 10.30m, 1.30m, 7, "Mendelevium", 0, 105, true, true, 1100.00m, "Менделеевий", 7, "Solid", 1955 },
                    { "Mg", 24.31m, 12, 173.00m, 1363.00m, "Твърдо вещество", 3, 1.74m, 1.31m, 3, "Magnesium", 2, 17, false, false, 923.00m, "Магнезий", 3, "Solid", 1755 },
                    { "Mn", 54.94m, 25, 197.00m, 2334.00m, "Твърдо вещество", 4, 7.21m, 1.55m, 4, "Manganese", 7, 35, false, false, 1519.00m, "Манган", 4, "Solid", 1774 },
                    { "Mo", 95.95m, 42, 209.00m, 4912.00m, "Твърдо вещество", 4, 10.28m, 2.16m, 5, "Molybdenum", 6, 36, false, false, 2896.00m, "Молибден", 5, "Solid", 1781 },
                    { "Mt", 277.15m, 109, 0.00m, 0.00m, "Твърдо вещество", 4, 27.00m, 0.00m, 7, "Meitnerium", 9, 37, true, true, 0.00m, "Майтнерий", 7, "Solid", 1982 },
                    { "N", 14.01m, 7, 155.00m, 77.36m, "Газ", 1, 1.25m, 3.04m, 2, "Nitrogen", 15, 3, false, false, 63.23m, "Азот", 2, "Gas", 1772 },
                    { "Na", 22.99m, 11, 227.00m, 1156.09m, "Твърдо вещество", 2, 0.97m, 0.93m, 3, "Sodium", 1, 12, false, false, 370.94m, "Натрий", 3, "Solid", 1807 },
                    { "Nb", 92.91m, 41, 207.00m, 5017.00m, "Твърдо вещество", 4, 8.57m, 1.60m, 5, "Niobium", 5, 38, false, false, 2750.00m, "Ниобий", 5, "Solid", 1801 },
                    { "Nd", 144.24m, 60, 229.00m, 3347.00m, "Твърдо вещество", 8, 7.01m, 1.14m, 6, "Neodymium", 0, 90, false, false, 1297.00m, "Неодим", 6, "Solid", 1885 },
                    { "Ne", 20.18m, 10, 154.00m, 27.10m, "Газ", 7, 0.90m, 0.00m, 2, "Neon", 18, 78, false, false, 24.56m, "Неон", 2, "Gas", 1898 },
                    { "Nh", 286.18m, 113, 0.00m, 0.00m, "Неопределено", 5, 16.00m, 0.00m, 7, "Nihonium", 13, 65, true, true, 0.00m, "Нихоний", 7, "NA", 2004 },
                    { "Ni", 58.69m, 28, 163.00m, 3003.00m, "Твърдо вещество", 4, 8.91m, 1.91m, 4, "Nickel", 10, 39, false, false, 1728.00m, "Никел", 4, "Solid", 1751 },
                    { "No", 259.10m, 102, 0.00m, 0.00m, "Твърдо вещество", 9, 9.90m, 1.30m, 7, "Nobelium", 0, 106, true, true, 1100.00m, "Нобелий", 7, "Solid", 1966 },
                    { "Np", 237.05m, 93, 221.00m, 4447.00m, "Твърдо вещество", 9, 19.38m, 1.36m, 7, "Neptunium", 0, 107, true, false, 912.00m, "Нептуний", 7, "Solid", 1940 },
                    { "O", 16.00m, 8, 152.00m, 90.19m, "Газ", 1, 1.43m, 3.44m, 2, "Oxygen", 16, 4, false, false, 54.36m, "Кислород", 2, "Gas", 1771 },
                    { "Og", 295.22m, 118, 0.00m, 0.00m, "Неопределено", 7, 7.20m, 0.00m, 7, "Oganesson", 18, 79, true, true, 0.00m, "Оганесон", 7, "NA", 2002 },
                    { "Os", 190.20m, 76, 216.00m, 5285.00m, "Твърдо вещество", 4, 22.59m, 2.20m, 6, "Osmium", 8, 40, false, false, 3306.00m, "Осмий", 6, "Solid", 1803 },
                    { "P", 30.97m, 15, 180.00m, 553.70m, "Твърдо вещество", 1, 1.82m, 2.19m, 3, "Phosphorus", 15, 5, false, false, 317.30m, "Фосфор", 3, "Solid", 1669 },
                    { "Pa", 231.04m, 91, 243.00m, 4300.00m, "Твърдо вещество", 9, 15.37m, 1.50m, 7, "Protactinium", 0, 108, true, false, 1841.00m, "Протактиний", 7, "Solid", 1913 },
                    { "Pb", 207.00m, 82, 202.00m, 2022.00m, "Твърдо вещество", 5, 11.34m, 2.33m, 6, "Lead", 14, 66, false, false, 600.61m, "Олово", 6, "Solid", 0 },
                    { "Pd", 106.42m, 46, 202.00m, 3236.00m, "Твърдо вещество", 4, 12.02m, 2.20m, 5, "Palladium", 10, 41, false, false, 1828.05m, "Паладий", 5, "Solid", 1802 },
                    { "Pm", 144.91m, 61, 236.00m, 3273.00m, "Твърдо вещество", 8, 7.26m, 1.13m, 6, "Promethium", 0, 91, true, false, 1315.00m, "Прометий", 6, "Solid", 1945 },
                    { "Po", 208.98m, 84, 197.00m, 1235.00m, "Твърдо вещество", 10, 9.20m, 2.00m, 6, "Polonium", 16, 115, true, false, 527.00m, "Полоний", 6, "Solid", 1898 },
                    { "Pr", 140.91m, 59, 239.00m, 3403.00m, "Твърдо вещество", 8, 6.77m, 1.13m, 6, "Praseodymium", 0, 92, false, false, 1208.00m, "Празеодим", 6, "Solid", 1885 },
                    { "Pt", 195.08m, 78, 209.00m, 4098.00m, "Твърдо вещество", 4, 21.45m, 2.28m, 6, "Platinum", 10, 42, false, false, 2041.40m, "Платина", 6, "Solid", 1735 },
                    { "Pu", 244.06m, 94, 243.00m, 3505.00m, "Твърдо вещество", 9, 19.85m, 1.28m, 7, "Plutonium", 0, 109, true, false, 912.50m, "Плутоний", 7, "Solid", 1940 }
                });

            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Symbol", "AtomicMass", "AtomicNumber", "AtomicRadius", "BoilingPoint", "BulgarianState", "ChemicalTypeId", "Density", "Electronegativity", "ElectronicLayers", "EnglishName", "Group", "Id", "IsRadioactive", "IsSynthetic", "MeltingPoint", "Name", "Period", "State", "YearFound" },
                values: new object[,]
                {
                    { "Ra", 226.03m, 88, 283.00m, 2010.00m, "Твърдо вещество", 3, 5.50m, 0.90m, 7, "Radium", 2, 18, true, false, 973.00m, "Радий", 7, "Solid", 1898 },
                    { "Rb", 85.47m, 37, 303.00m, 961.00m, "Твърдо вещество", 2, 1.53m, 0.82m, 5, "Rubidium", 1, 13, false, false, 312.45m, "Рубидий", 5, "Solid", 1861 },
                    { "Re", 186.21m, 75, 217.00m, 5903.00m, "Твърдо вещество", 4, 21.02m, 1.90m, 6, "Rhenium", 7, 43, false, false, 3459.00m, "Рений", 6, "Solid", 1908 },
                    { "Rf", 267.12m, 104, 0.00m, 5800.00m, "Твърдо вещество", 4, 17.00m, 0.00m, 7, "Rutherfordium", 4, 44, true, true, 2400.00m, "Ръдърфордий", 7, "Solid", 1964 },
                    { "Rg", 282.17m, 111, 0.00m, 0.00m, "Неопределено", 4, 22.00m, 0.00m, 7, "Roentgenium", 11, 45, true, true, 0.00m, "Рьонтгений", 7, "NA", 1994 },
                    { "Rh", 102.91m, 45, 195.00m, 3968.00m, "Твърдо вещество", 4, 12.41m, 2.28m, 5, "Rhodium", 9, 46, false, false, 2237.00m, "Родий", 5, "Solid", 1804 },
                    { "Rn", 222.02m, 86, 220.00m, 211.50m, "Газ", 7, 9.73m, 2.20m, 6, "Radon", 18, 80, true, false, 202.00m, "Радон", 6, "Gas", 1899 },
                    { "Ru", 101.10m, 44, 207.00m, 4423.00m, "Твърдо вещество", 4, 12.45m, 2.20m, 5, "Ruthenium", 8, 47, false, false, 2607.00m, "Рутений", 5, "Solid", 1844 },
                    { "S", 32.07m, 16, 180.00m, 717.80m, "Твърдо вещество", 1, 2.07m, 2.58m, 3, "Sulfur", 16, 6, false, false, 388.36m, "Сяра", 3, "Solid", 0 },
                    { "Sb", 121.76m, 51, 206.00m, 1908.00m, "Твърдо вещество", 10, 6.70m, 2.05m, 5, "Antimony", 15, 116, false, false, 903.78m, "Антимон", 5, "Solid", 0 },
                    { "Sc", 44.96m, 21, 211.00m, 3109.00m, "Твърдо вещество", 4, 2.99m, 1.36m, 4, "Scandium", 3, 48, false, false, 1814.00m, "Скандий", 4, "Solid", 1879 },
                    { "Se", 78.97m, 34, 190.00m, 958.00m, "Твърдо вещество", 1, 4.81m, 2.55m, 4, "Selenium", 16, 7, false, false, 494.00m, "Селен", 4, "Solid", 1817 },
                    { "Sg", 269.13m, 106, 0.00m, 0.00m, "Твърдо вещество", 4, 23.00m, 0.00m, 7, "Seaborgium", 6, 49, true, true, 0.00m, "Сиборгий", 7, "Solid", 1974 },
                    { "Si", 28.09m, 14, 210.00m, 3538.00m, "Твърдо вещество", 10, 2.33m, 1.90m, 3, "Silicon", 14, 117, false, false, 1687.00m, "Силиций", 3, "Solid", 1823 },
                    { "Sm", 150.40m, 62, 229.00m, 2173.00m, "Твърдо вещество", 8, 7.52m, 1.17m, 6, "Samarium", 0, 93, false, false, 1345.00m, "Самарий", 6, "Solid", 1879 },
                    { "Sn", 118.71m, 50, 217.00m, 2875.00m, "Твърдо вещество", 5, 7.27m, 1.96m, 5, "Tin", 14, 67, false, false, 505.08m, "Калай", 5, "Solid", 0 },
                    { "Sr", 87.62m, 38, 249.00m, 1650.00m, "Твърдо вещество", 3, 2.64m, 0.95m, 5, "Strontium", 2, 19, false, false, 1050.00m, "Стронций", 5, "Solid", 1787 },
                    { "Ta", 180.95m, 73, 217.00m, 5731.00m, "Твърдо вещество", 4, 16.69m, 1.50m, 6, "Tantalum", 5, 50, false, false, 3290.00m, "Тантал", 6, "Solid", 1802 },
                    { "Tb", 158.93m, 65, 221.00m, 3396.00m, "Твърдо вещество", 8, 8.23m, 1.20m, 6, "Terbium", 0, 94, false, false, 1629.00m, "Тербий", 6, "Solid", 1843 },
                    { "Tc", 96.91m, 43, 209.00m, 4538.00m, "Твърдо вещество", 4, 11.00m, 1.90m, 5, "Technetium", 7, 51, true, false, 2430.00m, "Технеций", 5, "Solid", 1937 },
                    { "Te", 127.60m, 52, 206.00m, 1261.00m, "Твърдо вещество", 10, 6.24m, 2.10m, 5, "Tellurium", 16, 118, false, false, 722.66m, "Телур", 5, "Solid", 1782 },
                    { "Th", 232.04m, 90, 237.00m, 5061.00m, "Твърдо вещество", 9, 11.70m, 1.30m, 7, "Thorium", 0, 110, true, false, 2023.00m, "Торий", 7, "Solid", 1829 },
                    { "Ti", 47.87m, 22, 187.00m, 3560.00m, "Твърдо вещество", 4, 4.51m, 1.54m, 4, "Titanium", 4, 52, false, false, 1941.00m, "Титан", 4, "Solid", 1791 },
                    { "Tl", 204.38m, 81, 196.00m, 1746.00m, "Твърдо вещество", 5, 11.85m, 1.62m, 6, "Thallium", 13, 68, false, false, 577.00m, "Талий", 6, "Solid", 1861 },
                    { "Tm", 168.93m, 69, 227.00m, 2223.00m, "Твърдо вещество", 8, 9.32m, 1.25m, 6, "Thulium", 0, 95, false, false, 1818.00m, "Тулий", 6, "Solid", 1879 },
                    { "Ts", 294.21m, 117, 0.00m, 0.00m, "Неопределено", 6, 7.10m, 0.00m, 7, "Tennessine", 17, 74, true, true, 0.00m, "Тенесин", 7, "NA", 2009 },
                    { "U", 238.03m, 92, 240.00m, 4404.00m, "Твърдо вещество", 9, 19.10m, 1.38m, 7, "Uranium", 0, 111, true, false, 1405.30m, "Уран", 7, "Solid", 1789 },
                    { "V", 50.94m, 23, 179.00m, 3680.00m, "Твърдо вещество", 4, 6.11m, 1.63m, 4, "Vanadium", 5, 53, false, false, 2183.00m, "Ванадий", 4, "Solid", 1801 },
                    { "W", 183.84m, 74, 210.00m, 6203.00m, "Твърдо вещество", 4, 19.20m, 2.36m, 6, "Tungsten", 6, 54, false, false, 3695.00m, "Волфрам", 6, "Solid", 1783 },
                    { "Xe", 131.29m, 54, 216.00m, 165.05m, "Газ", 7, 5.89m, 2.60m, 5, "Xenon", 18, 81, false, false, 161.40m, "Ксенон", 5, "Gas", 1898 },
                    { "Y", 88.91m, 39, 219.00m, 3203.00m, "Твърдо вещество", 4, 4.47m, 1.22m, 5, "Yttrium", 3, 55, false, false, 1799.00m, "Итрий", 5, "Solid", 1794 },
                    { "Yb", 173.05m, 70, 242.00m, 1469.00m, "Твърдо вещество", 8, 6.90m, 1.10m, 6, "Ytterbium", 0, 96, false, false, 1097.00m, "Интербий", 6, "Solid", 1878 },
                    { "Zn", 65.40m, 30, 139.00m, 1180.00m, "Твърдо вещество", 4, 7.14m, 1.65m, 4, "Zinc", 12, 56, false, false, 692.68m, "Цинк", 4, "Solid", 0 },
                    { "Zr", 91.22m, 40, 186.00m, 4650.00m, "Твърдо вещество", 4, 6.52m, 1.33m, 5, "Zirconium", 4, 57, false, false, 2125.00m, "Цирконий", 5, "Solid", 1789 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ac");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ag");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Al");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Am");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ar");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "As");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "At");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Au");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "B");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ba");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Be");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Bh");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Bi");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Bk");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Br");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ca");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cd");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ce");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cf");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cl");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cm");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cn");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Co");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cr");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cs");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Cu");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Db");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ds");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Dy");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Er");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Es");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Eu");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "F");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Fe");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Fl");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Fm");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Fr");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ga");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Gd");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ge");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "H");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "He");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Hf");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Hg");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ho");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Hs");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "I");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "In");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ir");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "K");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Kr");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "La");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Li");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Lr");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Lu");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Lv");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Mc");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Md");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Mg");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Mn");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Mo");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Mt");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "N");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Na");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Nb");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Nd");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ne");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Nh");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ni");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "No");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Np");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "O");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Og");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Os");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "P");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Pa");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Pb");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Pd");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Pm");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Po");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Pr");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Pt");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Pu");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ra");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Rb");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Re");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Rf");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Rg");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Rh");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Rn");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ru");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "S");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Sb");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Sc");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Se");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Sg");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Si");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Sm");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Sn");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Sr");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ta");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Tb");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Tc");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Te");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Th");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ti");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Tl");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Tm");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Ts");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "U");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "V");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "W");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Xe");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Y");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Yb");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Zn");

            migrationBuilder.DeleteData(
                table: "ChemicalElements",
                keyColumn: "Symbol",
                keyValue: "Zr");

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ChemicalTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ChemicalElements");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "Chemical type name *english*",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldComment: "Chemical type name english");

            migrationBuilder.AlterColumn<string>(
                name: "BulgarianName",
                table: "ChemicalTypes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                comment: "Chemical type name *bulgarian*",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldComment: "Chemical type name bulgarian");

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

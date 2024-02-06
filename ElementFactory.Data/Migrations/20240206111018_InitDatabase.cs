using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChemicalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Chemical Type identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Chemical type name english"),
                    BulgarianName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Chemical type name bulgarian")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalTypes", x => x.Id);
                },
                comment: "Chemical Type Class");

            migrationBuilder.CreateTable(
                name: "Founders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Founder identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Founder first name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Founder last name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Founders", x => x.Id);
                },
                comment: "Founder Class");

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Question identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Question description"),
                    RightAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Question right answer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                },
                comment: "Question Class");

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Test identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Test title"),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Test category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                },
                comment: "Test Class");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChemicalElements",
                columns: table => new
                {
                    Symbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false, comment: "Chemical element symbol => PK"),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Chemical element name *bulgarian*"),
                    EnglishName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Chemical element name *english*"),
                    AtomicNumber = table.Column<int>(type: "int", nullable: false, comment: "Chemical element atomic number"),
                    AtomicMass = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Chemical element atomic mass"),
                    Group = table.Column<int>(type: "int", nullable: false, comment: "Chemical element group"),
                    Period = table.Column<int>(type: "int", nullable: false, comment: "Chemical element period"),
                    ElectronicLayers = table.Column<int>(type: "int", nullable: false, comment: "Chemical element electronic layers"),
                    IsRadioactive = table.Column<bool>(type: "bit", nullable: false, comment: "Is chemical element radioactive - flag"),
                    IsSynthetic = table.Column<bool>(type: "bit", nullable: false, comment: "Is chemical element synthetic - flag"),
                    ChemicalTypeId = table.Column<int>(type: "int", nullable: false, comment: "Chemical element id for type"),
                    BoilingPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Chemical element boiling point"),
                    MeltingPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Chemical element melting point"),
                    YearFound = table.Column<int>(type: "int", nullable: false, comment: "Chemical element year when found"),
                    State = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Chemical element state *english*"),
                    BulgarianState = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Chemical element state *bulgarian*"),
                    Electronegativity = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Chemical element electronegativity"),
                    AtomicRadius = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Chemical element atomic radius"),
                    Density = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Chemical element density")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalElements", x => x.Symbol);
                    table.ForeignKey(
                        name: "FK_ChemicalElements_ChemicalTypes_ChemicalTypeId",
                        column: x => x.ChemicalTypeId,
                        principalTable: "ChemicalTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Chemical Element Class");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Answer identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Answer value"),
                    QuestionId = table.Column<int>(type: "int", nullable: false, comment: "Answer question Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Answer Class");

            migrationBuilder.CreateTable(
                name: "QuestionsTests",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false, comment: "Question identificator"),
                    TestId = table.Column<int>(type: "int", nullable: false, comment: "Test identificator")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsTests", x => new { x.QuestionId, x.TestId });
                    table.ForeignKey(
                        name: "FK_QuestionsTests_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionsTests_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoundersChemicalElements",
                columns: table => new
                {
                    FounderId = table.Column<int>(type: "int", nullable: false, comment: "Founder identificator"),
                    ChemicalElementSymbol = table.Column<string>(type: "nvarchar(2)", nullable: false, comment: "Chemical element symbol => PK")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoundersChemicalElements", x => new { x.FounderId, x.ChemicalElementSymbol });
                    table.ForeignKey(
                        name: "FK_FoundersChemicalElements_ChemicalElements_ChemicalElementSymbol",
                        column: x => x.ChemicalElementSymbol,
                        principalTable: "ChemicalElements",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoundersChemicalElements_Founders_FounderId",
                        column: x => x.FounderId,
                        principalTable: "Founders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Founder Chemical Element Class");

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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
                    { 1, "В коя група е химичният елемент Na?", "Първа А" },
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
                    { 25, "В какъв йон се превръща атомът на хлора при реакция?", "Отрицателен със заряд 1-" },
                    { 26, "Как се наричат солите на хлора?", "Хлориди" },
                    { 27, "От коя валентност е хлорът в съединението си с водорода?", "1" },
                    { 28, "Хипохлористата киселина се разлага до:", "HCl + O" },
                    { 29, "Газът хлор има силен, приятен мирис", "Грешно" },
                    { 30, "За какво се използва хлорът в практиката?", "Дезинфекция на водите" },
                    { 31, "Простото вещество Ca е:", "Алкалоземен метал" },
                    { 32, "С какъв строеж е простото вещество Ca?", "Кристален" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
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
                    { 45, "Разтоворът на Ca(OH)2 е с pH:", "11" },
                    { 46, "В кой от редовете са посочени само неорганични съединения:", "CO, CO2, H2CO3, Na2CO3" },
                    { 47, "Каква валентност проявява C в неговите ОС?", "4" },
                    { 48, "Кое е най-точното определение за ароматните ВВ?", "ВВ с по-сложен строеж, които са циклични" },
                    { 49, "Кое от посочените съединения е известно под името \"Газ гризу\":", "CH4" },
                    { 50, "\"Халогенирането\" на метан е заместителна реакция.", "Вярно" },
                    { 51, "Всяко ОС при взаимодействие с кислород(горене) се разлага до въглероден диоксид и вода", "Вярно" },
                    { 52, "Кое от от следните съединения е нонан", "C9H20" },
                    { 53, "Каква е общата молекулна формула на алкените", "CnH2n" },
                    { 54, "Характерни за алкените са заместителните реакции, поради наличието на сложната двойна връзка", "Грешно" },
                    { 55, "\"Хидрирането\" на алкени протична при наличието на:", "И трите изброени" },
                    { 56, "Наличието на какво се доказва с разтвор на KMnO4?", "Сложни връзки" },
                    { 57, "При присъединяването на полярни H-съдържащи молекули към молекули на несиметрияни алкени се спазва правилото на:", "Марковников" },
                    { 58, "За да се спре реакцията на \"Хидриране\" на алкините, така че от алкин да се получи алкен, се използва катализатор:", "Pb(CH3COO)2" },
                    { 59, "2,4,6-тринитро толуен(TNT) се получава при взаимодействието на:", "Толуен и HNO3 в излишък" },
                    { 60, "При взаимодействието на фенол и натрий се получава:", "Натриев феноксид и 1/2 H2" },
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
                    { 74, "Коя е правилната последователност на процесите, през които минава механизмът на разтварянето?", "Разграждане на кристалната решетка (ако има такава), солватация, дифузия" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "RightAnswer" },
                values: new object[,]
                {
                    { 75, "Как се нарича обратната реакция на разтварянето, ако е погледнато като обратим проес?", "Кристализация" },
                    { 76, "Видовете разтвори според състоянието им от състоянието на равновесие са само наситен и ненаситен.", "Грешно" },
                    { 77, "По коя от формулите НЕ можем да определим концентрацията на даден разтвор?", "m(р-р) = M(А) * n(р-р)" },
                    { 78, "Разтворите са устойчиви системи, чиито размери на частиците НЕ надвишават:", "1 нанометър" },
                    { 79, "Процесът на кристализация е съпроводен с положителен топлинен ефект (+Q1).", "Грешно" },
                    { 80, "На кой ред са изброени всички общи свойства на разтворите?", "Понижаването на температурата на замръзване, повишаването на температурата на кипене, дифузия, понижаване на парното налягане, осмоза" },
                    { 81, "Коя е най-точната формула за определяне на осмотичното налягане?", "π = i*c*R*T" },
                    { 82, "Ако имаме една кръвна клетка, на която цитозолът е с концентрация 0.9%, а кръвта около нея е с концентрация, по-висока от 1.2%, то спрямо клетката разтворът в околната среда (кръвта) ще бъде:", "Хипертоничен" },
                    { 83, "На кой ред всички изброени вещества са електролити?", "CuSO4, NaOH, H2O, Ca(OH)2" },
                    { 84, "Какви видове разтвори има според степента на електролитна дисоциация?", "Средни, слаби, силни" },
                    { 85, "Водата е електролит.", "Вярно" },
                    { 86, "Коя от частиците е с най-малък атомен радиус?", "Al3+" },
                    { 87, "Кое е най-точното определение на \"Електронен облак\"?", "Част от пространството, което е около самото ядро, в която шанса за намиране на електрона е приблизително 90%" },
                    { 88, "Атомните орбитали с едно и също главно и орбитално квантово число образуват електронен слой.", "Грешно" },
                    { 89, "В коя група всички означени вещества са с неполярни молекули?", "CO2, BeH2, N2" },
                    { 90, "Кое от следните твърдения е вярно за масовото число?", "То е равно на сумата от броя на протоните и неутроните" },
                    { 91, "Здравината на ковалентната връзка нараства с увеличаване на нейната кратност.", "Вярно" },
                    { 92, "В кой от редовете са изброени само вещества, в които има кратна ковалентна връзка?", "C2H2, N2, CO2" },
                    { 93, "В кой от редовете са изброени само вещества с йонна химична връзка?", "NaH, K2O, BaCl2" },
                    { 94, "π-връзка може да се образува между еднакви по вид атоми.", "Вярно" },
                    { 95, "В молекулата на CS2 каква е хибридизацията на централния атом?", "sp" },
                    { 96, "Коя от двойките елементи не се свързва с йонна връзка?", "F и O" },
                    { 97, "Еквивалентните атомни орбитали се заемат първоначално от двойни електрони с паралелни спинове.", "Грешно" },
                    { 98, "За веществото X е известно, че има висока температура на топене, ковко е и не се разтваря във вода. Какъв е видът на кристалната решетка на това вещество?", "Метална" },
                    { 99, "На кое от изброените вещества хибридизацията на централния атом е sp^3d^2?", "SF6" },
                    { 100, "Йонизационната енергия характеризира редукционната активност на атомите.", "Вярно" },
                    { 101, "Количеството вещество, което съответства на 5.6г азот, е:", "0.2 mol" },
                    { 102, "Кое от твърденията за ендотермични реакции е вярно? При ендотермични реакции:", "се поглъща топлина, ΔH > 0 и реагентите са по-стабилни" },
                    { 103, "При изгарянето на 9 грама алуминий, като знаете че M(Al) = 27g/mol, в кислородна среда се отделят 229kJ топлина. Това означава, че стандартната енталпия на образуване на диалуминиевия триоксид е равна на:", "-1374 kJ/mol" },
                    { 104, "Термохимичната функция \"Енергия на Гибс\" се дефинира чрез:", "G = H - T*S" },
                    { 105, "Ентропията расте, когато се преминава от едно по-неподредено към по-подредено състояние.", "Грешно" },
                    { 106, "Ако приемем, че реакцията протича по уравнението: S(тв.) + O2(г.) => SO2(г.), то кинетичното уравнение за процеса е:", "v = k * c(O2)" },
                    { 107, "Кинетичното уравнение на химичен процес е v = k * c(A) * c^2(B). Как ще се промени скоростта на процеса при понижаване на налягането два пъти?", "Ще се понижи осем пъти" },
                    { 108, "Ендотермичните процеси не могат да протичат спонтанно.", "Грешно" },
                    { 109, "Кое от твърденията НЕ е вярно?", "Ензимите притежават общите свойства на катализаторите" },
                    { 110, "Кое от следните определения описва \"Вторият закон на Фарадей\"", "За отделянето на един еквивалент от дадено вещество е необходимо през разтвора да преминат 96 500C електричен заряд. Електрохимичният еквивалент се пресмята по формулата: k = M/z*F" },
                    { 111, "При еднаква молна концентрация и температура = const, най-високото осмотично налягане от посочените по-долу има разтворът на:", "Сярна киселина" },
                    { 112, "При ΔG < 0 реакцията протича спонтанно, а при ΔG = 0 системата се намира в динамично равновесие", "Вярно" },
                    { 113, "При взаимодействие на 1cm^3 1M разтвор на калиев хлорид и 1cm^3 0.1M разтвор на сребърен нитрат е получен зол. Най-бързата коагулация на колоидния разтвор могат да предизвикат:", "Al3+" },
                    { 114, "В коя от групите всички означени вещества оцветяват лакмуса в синьо?", "Ca(OH)2, NH4OH, NaHCO3" },
                    { 115, "Адсорбтив е вещество, което задържа на повърхността си други вещества.", "Грешно" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Title" },
                values: new object[] { 1, "7 клас", "Метали. Натрий и неговите съединения" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Category", "Title" },
                values: new object[,]
                {
                    { 2, "7 клас", "Неметали. Хлор и неговите съединения" },
                    { 3, "8-9 клас", "Алкалоземни метали. Калций и неговите съединения" },
                    { 4, "8-9 клас", "Органична химия. Въглерод и неговите органични съединения" },
                    { 5, "10 клас", "Характеристики на химичните процеси" },
                    { 6, "10 клас", "Разтвори и химични процеси във водни разтвори" },
                    { 7, "11-12 клас", "Строеж и свойства на веществата" },
                    { 8, "11-12 клас", "11-12 клас. Обобщителен тест" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Втора А" },
                    { 2, 1, "Седма А" },
                    { 3, 1, "Първа А" },
                    { 4, 1, "Първа Б" },
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
                    { 42, 11, "В малиновочервено" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 43, 11, "В синьо" },
                    { 44, 11, "В жълто" },
                    { 45, 12, "K" },
                    { 46, 12, "Li" },
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
                    { 84, 22, "Малиновочервен" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 85, 22, "Виолетов" },
                    { 86, 22, "Син" },
                    { 87, 23, "Сода каустик" },
                    { 88, 23, "Бертолетова сол" },
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
                    { 116, 30, "Производство на мебели" },
                    { 117, 31, "Алкален метал" },
                    { 118, 31, "Алкалоземен метал" },
                    { 119, 31, "Халоген" },
                    { 120, 31, "Преходен метал" },
                    { 121, 32, "Молекулен" },
                    { 122, 32, "Йонен" },
                    { 123, 32, "Кристален" },
                    { 124, 32, "Атомен" },
                    { 125, 33, "1" },
                    { 126, 33, "2" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
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
                    { 151, 40, "Киселинен" },
                    { 152, 40, "Основен" },
                    { 153, 40, "Неутрален" },
                    { 154, 40, "Смесен" },
                    { 155, 41, "CaO + H2O => CaOH + H2" },
                    { 156, 41, "Ca + 2HCl => CaCl + 2H" },
                    { 157, 41, "Ca + H2 => 2CaH" },
                    { 158, 41, "Ca + 2H2O => Ca(OH)2+H2" },
                    { 159, 42, "Вярно" },
                    { 160, 42, "Грешно" },
                    { 161, 43, "Бял" },
                    { 162, 43, "Керемиденочервен" },
                    { 163, 43, "Син" },
                    { 164, 43, "Зелен" },
                    { 165, 44, "Ca(OH)2 с вода" },
                    { 166, 44, "Ca с киселина" },
                    { 167, 44, "CaCO3 с киселина" },
                    { 168, 44, "Ca с киселинен оксид" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 169, 45, "4" },
                    { 170, 45, "7" },
                    { 171, 45, "2" },
                    { 172, 45, "11" },
                    { 173, 46, "C6H6, C6H5OH, CO3" },
                    { 174, 46, "CO2, C6H12O6, C3H5(OH)3" },
                    { 175, 46, "CO, CO2, H2CO3, Na2CO3" },
                    { 176, 46, "CO, H2CO3, C2H4(ONa)2" },
                    { 177, 47, "1" },
                    { 178, 47, "2" },
                    { 179, 47, "3" },
                    { 180, 47, "4" },
                    { 181, 48, "ВВ, които съдържат само прости връзки" },
                    { 182, 48, "ВВ, които съдържат поне една сложна връзка" },
                    { 183, 48, "ВВ с по-сложен строеж, които са циклични" },
                    { 184, 48, "ВВ, които съдържат само сложни връзки" },
                    { 185, 49, "CH4" },
                    { 186, 49, "CO2" },
                    { 187, 49, "CO" },
                    { 188, 49, "C2H2" },
                    { 189, 50, "Вярно" },
                    { 190, 50, "Грешно" },
                    { 191, 51, "Вярно" },
                    { 192, 51, "Грешно" },
                    { 193, 52, "C10H22" },
                    { 194, 52, "C9H18" },
                    { 195, 52, "C9H16" },
                    { 196, 52, "C9H20" },
                    { 197, 53, "CnH2n" },
                    { 198, 53, "CnH2n+2" },
                    { 199, 53, "CnH2n-2" },
                    { 200, 53, "CnHn" },
                    { 201, 54, "Вярно" },
                    { 202, 54, "Грешно" },
                    { 203, 55, "Температура" },
                    { 204, 55, "Налягане" },
                    { 205, 55, "Катализатор(Ni)" },
                    { 206, 55, "И трите изброени" },
                    { 207, 56, "Прости връзки" },
                    { 208, 56, "Въглеродни атоми" },
                    { 209, 56, "Водородни атоми" },
                    { 210, 56, "Сложни връзки" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 211, 57, "Бойл Мариот" },
                    { 212, 57, "Марковников" },
                    { 213, 57, "Аристотел" },
                    { 214, 57, "Менделеев" },
                    { 215, 58, "Ni" },
                    { 216, 58, "Hg2+" },
                    { 217, 58, "CCl4" },
                    { 218, 58, "Pb(CH3COO)2" },
                    { 219, 59, "Толуен и HNO3 в излишък" },
                    { 220, 59, "Фенол и HNO3" },
                    { 221, 59, "Бензен и HNO3" },
                    { 222, 59, "Бензен и нитратни соли" },
                    { 223, 60, "Ацеталдехид" },
                    { 224, 60, "Бензен и 2Na" },
                    { 225, 60, "Феноксиден анион и водороден катион" },
                    { 226, 60, "Натриев феноксид и 1/2 H2" },
                    { 227, 71, "Вода и разтварящо се вещество" },
                    { 228, 71, "Течен разтворител и захар" },
                    { 229, 71, "Разтворител и разтварящо се вещество" },
                    { 230, 71, "Нито едно от изброените" },
                    { 231, 72, "\"Йони се разтварят в йони\"" },
                    { 232, 72, "\"В разтвор с ниска концентрация се разтваря вещество с висока концентрация\"" },
                    { 233, 72, "\"Подобни се разтварят в подобни\"" },
                    { 234, 72, "\"Всеки разтвор е смес от вода и друго вещество с по-висока концентрация\"" },
                    { 235, 73, "Молекулни и йонни" },
                    { 236, 73, "Течни и твърди" },
                    { 237, 73, "Соли, основи и киселини" },
                    { 238, 73, "Според частиците на разтвореното вещество не се разглеждат различни по видове разтвори" },
                    { 239, 74, "Солватация, дифузия, разграждане на кристалната решетка (ако има такава)" },
                    { 240, 74, "Разграждане на кристалната решетка (ако има такава), солватация, дифузия" },
                    { 241, 74, "Дифузия, разграждане на кристалната решетка (ако има такава), солватация" },
                    { 242, 74, "Разграждане на кристалната решетка (ако има такава), дифузия, солватация" },
                    { 243, 75, "Йонизация" },
                    { 244, 75, "Солватация" },
                    { 245, 75, "Дифузия" },
                    { 246, 75, "Кристализация" },
                    { 247, 76, "Вярно" },
                    { 248, 76, "Грешно" },
                    { 249, 77, "m(р-р) = M(А) * n(р-р)" },
                    { 250, 77, "S(А) = m(А) / 100g(р-р)" },
                    { 251, 77, "W(А) = m(А) / m(р-р)" },
                    { 252, 77, "C(А) = n(А) / V" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
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
                    { 268, 82, "Хипотоничен" },
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
                    { 280, 85, "Грешно" },
                    { 281, 86, "Na+" },
                    { 282, 86, "Ne" },
                    { 283, 86, "Al3+" },
                    { 284, 86, "F-" },
                    { 285, 87, "Състояние, което се определя от стойностите на квантовите числа n, l и m" },
                    { 286, 87, "Функция, която описва електроните в една атомна система" },
                    { 287, 87, "Вероятността за намиране на електрона в пространството около ядрото" },
                    { 288, 87, "Част от пространството, което е около самото ядро, в която шансът за намиране на електрона е приблизително 90%" },
                    { 289, 88, "Вярно" },
                    { 290, 88, "Грешно" },
                    { 291, 89, "CO2, BeH2, N2" },
                    { 292, 89, "HBr, CO2, N2" },
                    { 293, 89, "NH3, H2О, N2" },
                    { 294, 89, "H2О, CH4, O2" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
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
                    { 322, 98, "Атомна" },
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
                    { 335, 102, "се поглъща топлина, ΔH < 0 и продуктите са по-стабилни" },
                    { 336, 102, "се отделя топлина, ΔH < 0 и продуктите са по-стабилни" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 337, 102, "се отделя топлина, ΔH > 0 и реагентите са по-стабилни" },
                    { 338, 102, "се поглъща топлина, ΔH > 0 и реагентите са по-стабилни" },
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
                    { 364, 110, "Масата на веществото m, което се отделя на електродите, е правопропорционална на големината на тока, протекъл през електролита, и времето, за което протича: m = k*I*t" },
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
                    { 378, 114, "AlCl3, C6H5OH, H2SO4" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 379, 114, "KOH, K2CO3, K2SO4" },
                    { 380, 114, "Ca(OH)2, NH4OH, NaHCO3" },
                    { 381, 115, "Вярно" },
                    { 382, 115, "Грешно" }
                });

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
                    { "Fr", 223.02m, 87, 348.00m, 950.00m, "Твърдо вещество", 2, 2.48m, 0.79m, 7, "Francium", 1, 9, true, false, 300.00m, "Франций", 7, "Solid", 1939 }
                });

            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Symbol", "AtomicMass", "AtomicNumber", "AtomicRadius", "BoilingPoint", "BulgarianState", "ChemicalTypeId", "Density", "Electronegativity", "ElectronicLayers", "EnglishName", "Group", "Id", "IsRadioactive", "IsSynthetic", "MeltingPoint", "Name", "Period", "State", "YearFound" },
                values: new object[,]
                {
                    { "Ga", 69.72m, 31, 187.00m, 2676.00m, "Твърдо вещество", 5, 5.91m, 1.81m, 4, "Gallium", 13, 61, false, false, 302.91m, "Галий", 4, "Solid", 1875 },
                    { "Gd", 157.20m, 64, 237.00m, 3546.00m, "Твърдо вещество", 8, 7.90m, 1.20m, 6, "Gadolinium", 0, 86, false, false, 1585.00m, "Гадолиний", 6, "Solid", 1880 },
                    { "Ge", 72.63m, 32, 211.00m, 3106.00m, "Твърдо вещество", 10, 5.32m, 2.01m, 4, "Germanium", 14, 114, false, false, 1211.40m, "Германий", 4, "Solid", 1886 },
                    { "H", 1.01m, 1, 120.00m, 20.27m, "Газ", 1, 0.09m, 2.20m, 1, "Hydrogen", 1, 2, false, false, 13.99m, "Водород", 1, "Gas", 1766 },
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
                    { "Pm", 144.91m, 61, 236.00m, 3273.00m, "Твърдо вещество", 8, 7.26m, 1.13m, 6, "Promethium", 0, 91, true, false, 1315.00m, "Прометий", 6, "Solid", 1945 }
                });

            migrationBuilder.InsertData(
                table: "ChemicalElements",
                columns: new[] { "Symbol", "AtomicMass", "AtomicNumber", "AtomicRadius", "BoilingPoint", "BulgarianState", "ChemicalTypeId", "Density", "Electronegativity", "ElectronicLayers", "EnglishName", "Group", "Id", "IsRadioactive", "IsSynthetic", "MeltingPoint", "Name", "Period", "State", "YearFound" },
                values: new object[,]
                {
                    { "Po", 208.98m, 84, 197.00m, 1235.00m, "Твърдо вещество", 10, 9.20m, 2.00m, 6, "Polonium", 16, 115, true, false, 527.00m, "Полоний", 6, "Solid", 1898 },
                    { "Pr", 140.91m, 59, 239.00m, 3403.00m, "Твърдо вещество", 8, 6.77m, 1.13m, 6, "Praseodymium", 0, 92, false, false, 1208.00m, "Празеодим", 6, "Solid", 1885 },
                    { "Pt", 195.08m, 78, 209.00m, 4098.00m, "Твърдо вещество", 4, 21.45m, 2.28m, 6, "Platinum", 10, 42, false, false, 2041.40m, "Платина", 6, "Solid", 1735 },
                    { "Pu", 244.06m, 94, 243.00m, 3505.00m, "Твърдо вещество", 9, 19.85m, 1.28m, 7, "Plutonium", 0, 109, true, false, 912.50m, "Плутоний", 7, "Solid", 1940 },
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

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
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
                    { 15, 1 },
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
                    { 30, 2 },
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
                    { 45, 3 },
                    { 46, 4 }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
                    { 47, 4 },
                    { 48, 4 },
                    { 49, 4 },
                    { 50, 4 },
                    { 51, 4 },
                    { 52, 4 },
                    { 53, 4 },
                    { 54, 4 },
                    { 55, 4 },
                    { 56, 4 },
                    { 57, 4 },
                    { 58, 4 },
                    { 59, 4 },
                    { 60, 4 },
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
                    { 85, 6 },
                    { 86, 7 },
                    { 87, 7 },
                    { 88, 7 }
                });

            migrationBuilder.InsertData(
                table: "QuestionsTests",
                columns: new[] { "QuestionId", "TestId" },
                values: new object[,]
                {
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
                    { 109, 8 },
                    { 110, 8 },
                    { 111, 8 },
                    { 112, 8 },
                    { 113, 8 },
                    { 114, 8 },
                    { 115, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalElements_ChemicalTypeId",
                table: "ChemicalElements",
                column: "ChemicalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FoundersChemicalElements_ChemicalElementSymbol",
                table: "FoundersChemicalElements",
                column: "ChemicalElementSymbol");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsTests_TestId",
                table: "QuestionsTests",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FoundersChemicalElements");

            migrationBuilder.DropTable(
                name: "QuestionsTests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ChemicalElements");

            migrationBuilder.DropTable(
                name: "Founders");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "ChemicalTypes");
        }
    }
}

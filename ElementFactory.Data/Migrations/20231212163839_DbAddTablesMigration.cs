using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class DbAddTablesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChemicalType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Founder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Founder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChemicalElement",
                columns: table => new
                {
                    Symbol = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    AtomicNumber = table.Column<int>(type: "int", nullable: false),
                    AtomicMass = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Group = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    ElectronicLayers = table.Column<int>(type: "int", nullable: false),
                    IsRadioactive = table.Column<bool>(type: "bit", nullable: false),
                    IsSynthetic = table.Column<bool>(type: "bit", nullable: false),
                    ChemicalTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalElement", x => x.Symbol);
                    table.ForeignKey(
                        name: "FK_ChemicalElement_ChemicalType_ChemicalTypeId",
                        column: x => x.ChemicalTypeId,
                        principalTable: "ChemicalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Chemical Element Class");

            migrationBuilder.CreateTable(
                name: "ChemicalElementQuestion",
                columns: table => new
                {
                    ChemicalElementSymbol = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalElementQuestion", x => new { x.ChemicalElementSymbol, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_ChemicalElementQuestion_ChemicalElement_ChemicalElementSymbol",
                        column: x => x.ChemicalElementSymbol,
                        principalTable: "ChemicalElement",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChemicalElementQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FounderChemicalElement",
                columns: table => new
                {
                    FounderId = table.Column<int>(type: "int", nullable: false),
                    ChemicalElementSymbol = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FounderChemicalElement", x => new { x.FounderId, x.ChemicalElementSymbol });
                    table.ForeignKey(
                        name: "FK_FounderChemicalElement_ChemicalElement_ChemicalElementSymbol",
                        column: x => x.ChemicalElementSymbol,
                        principalTable: "ChemicalElement",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FounderChemicalElement_Founder_FounderId",
                        column: x => x.FounderId,
                        principalTable: "Founder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalElement_ChemicalTypeId",
                table: "ChemicalElement",
                column: "ChemicalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalElementQuestion_QuestionId",
                table: "ChemicalElementQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_FounderChemicalElement_ChemicalElementSymbol",
                table: "FounderChemicalElement",
                column: "ChemicalElementSymbol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChemicalElementQuestion");

            migrationBuilder.DropTable(
                name: "FounderChemicalElement");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "ChemicalElement");

            migrationBuilder.DropTable(
                name: "Founder");

            migrationBuilder.DropTable(
                name: "ChemicalType");
        }
    }
}

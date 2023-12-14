using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElementFactory.Data.Migrations
{
    public partial class InitialMigrationAlexNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalElement_ChemicalType_ChemicalTypeId",
                table: "ChemicalElement");

            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalElementQuestion_ChemicalElement_ChemicalElementSymbol",
                table: "ChemicalElementQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalElementQuestion_Question_QuestionId",
                table: "ChemicalElementQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_FounderChemicalElement_ChemicalElement_ChemicalElementSymbol",
                table: "FounderChemicalElement");

            migrationBuilder.DropForeignKey(
                name: "FK_FounderChemicalElement_Founder_FounderId",
                table: "FounderChemicalElement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FounderChemicalElement",
                table: "FounderChemicalElement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Founder",
                table: "Founder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalType",
                table: "ChemicalType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalElementQuestion",
                table: "ChemicalElementQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalElement",
                table: "ChemicalElement");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "FounderChemicalElement",
                newName: "FoundersChemicalElements");

            migrationBuilder.RenameTable(
                name: "Founder",
                newName: "Founders");

            migrationBuilder.RenameTable(
                name: "ChemicalType",
                newName: "ChemicalTypes");

            migrationBuilder.RenameTable(
                name: "ChemicalElementQuestion",
                newName: "ChemicalElementsQuestions");

            migrationBuilder.RenameTable(
                name: "ChemicalElement",
                newName: "ChemicalElements");

            migrationBuilder.RenameIndex(
                name: "IX_FounderChemicalElement_ChemicalElementSymbol",
                table: "FoundersChemicalElements",
                newName: "IX_FoundersChemicalElements_ChemicalElementSymbol");

            migrationBuilder.RenameIndex(
                name: "IX_ChemicalElementQuestion_QuestionId",
                table: "ChemicalElementsQuestions",
                newName: "IX_ChemicalElementsQuestions_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_ChemicalElement_ChemicalTypeId",
                table: "ChemicalElements",
                newName: "IX_ChemicalElements_ChemicalTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoundersChemicalElements",
                table: "FoundersChemicalElements",
                columns: new[] { "FounderId", "ChemicalElementSymbol" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Founders",
                table: "Founders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalTypes",
                table: "ChemicalTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalElementsQuestions",
                table: "ChemicalElementsQuestions",
                columns: new[] { "ChemicalElementSymbol", "QuestionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalElements",
                table: "ChemicalElements",
                column: "Symbol");

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalElements_ChemicalTypes_ChemicalTypeId",
                table: "ChemicalElements",
                column: "ChemicalTypeId",
                principalTable: "ChemicalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalElementsQuestions_ChemicalElements_ChemicalElementSymbol",
                table: "ChemicalElementsQuestions",
                column: "ChemicalElementSymbol",
                principalTable: "ChemicalElements",
                principalColumn: "Symbol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalElementsQuestions_Questions_QuestionId",
                table: "ChemicalElementsQuestions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoundersChemicalElements_ChemicalElements_ChemicalElementSymbol",
                table: "FoundersChemicalElements",
                column: "ChemicalElementSymbol",
                principalTable: "ChemicalElements",
                principalColumn: "Symbol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoundersChemicalElements_Founders_FounderId",
                table: "FoundersChemicalElements",
                column: "FounderId",
                principalTable: "Founders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalElements_ChemicalTypes_ChemicalTypeId",
                table: "ChemicalElements");

            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalElementsQuestions_ChemicalElements_ChemicalElementSymbol",
                table: "ChemicalElementsQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalElementsQuestions_Questions_QuestionId",
                table: "ChemicalElementsQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_FoundersChemicalElements_ChemicalElements_ChemicalElementSymbol",
                table: "FoundersChemicalElements");

            migrationBuilder.DropForeignKey(
                name: "FK_FoundersChemicalElements_Founders_FounderId",
                table: "FoundersChemicalElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoundersChemicalElements",
                table: "FoundersChemicalElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Founders",
                table: "Founders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalTypes",
                table: "ChemicalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalElementsQuestions",
                table: "ChemicalElementsQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChemicalElements",
                table: "ChemicalElements");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "FoundersChemicalElements",
                newName: "FounderChemicalElement");

            migrationBuilder.RenameTable(
                name: "Founders",
                newName: "Founder");

            migrationBuilder.RenameTable(
                name: "ChemicalTypes",
                newName: "ChemicalType");

            migrationBuilder.RenameTable(
                name: "ChemicalElementsQuestions",
                newName: "ChemicalElementQuestion");

            migrationBuilder.RenameTable(
                name: "ChemicalElements",
                newName: "ChemicalElement");

            migrationBuilder.RenameIndex(
                name: "IX_FoundersChemicalElements_ChemicalElementSymbol",
                table: "FounderChemicalElement",
                newName: "IX_FounderChemicalElement_ChemicalElementSymbol");

            migrationBuilder.RenameIndex(
                name: "IX_ChemicalElementsQuestions_QuestionId",
                table: "ChemicalElementQuestion",
                newName: "IX_ChemicalElementQuestion_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_ChemicalElements_ChemicalTypeId",
                table: "ChemicalElement",
                newName: "IX_ChemicalElement_ChemicalTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FounderChemicalElement",
                table: "FounderChemicalElement",
                columns: new[] { "FounderId", "ChemicalElementSymbol" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Founder",
                table: "Founder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalType",
                table: "ChemicalType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalElementQuestion",
                table: "ChemicalElementQuestion",
                columns: new[] { "ChemicalElementSymbol", "QuestionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChemicalElement",
                table: "ChemicalElement",
                column: "Symbol");

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalElement_ChemicalType_ChemicalTypeId",
                table: "ChemicalElement",
                column: "ChemicalTypeId",
                principalTable: "ChemicalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalElementQuestion_ChemicalElement_ChemicalElementSymbol",
                table: "ChemicalElementQuestion",
                column: "ChemicalElementSymbol",
                principalTable: "ChemicalElement",
                principalColumn: "Symbol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalElementQuestion_Question_QuestionId",
                table: "ChemicalElementQuestion",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FounderChemicalElement_ChemicalElement_ChemicalElementSymbol",
                table: "FounderChemicalElement",
                column: "ChemicalElementSymbol",
                principalTable: "ChemicalElement",
                principalColumn: "Symbol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FounderChemicalElement_Founder_FounderId",
                table: "FounderChemicalElement",
                column: "FounderId",
                principalTable: "Founder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

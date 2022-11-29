using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreHomework2.Migrations
{
    /// <inheritdoc />
    public partial class MarksChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_StudentCards_StudentCardId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subjects_SubjectId",
                table: "Mark");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mark",
                table: "Mark");

            migrationBuilder.RenameTable(
                name: "Mark",
                newName: "Marks");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_SubjectId",
                table: "Marks",
                newName: "IX_Marks_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_StudentCardId",
                table: "Marks",
                newName: "IX_Marks_StudentCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marks",
                table: "Marks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_StudentCards_StudentCardId",
                table: "Marks",
                column: "StudentCardId",
                principalTable: "StudentCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_StudentCards_StudentCardId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marks",
                table: "Marks");

            migrationBuilder.RenameTable(
                name: "Marks",
                newName: "Mark");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_SubjectId",
                table: "Mark",
                newName: "IX_Mark_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_StudentCardId",
                table: "Mark",
                newName: "IX_Mark_StudentCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mark",
                table: "Mark",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_StudentCards_StudentCardId",
                table: "Mark",
                column: "StudentCardId",
                principalTable: "StudentCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subjects_SubjectId",
                table: "Mark",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

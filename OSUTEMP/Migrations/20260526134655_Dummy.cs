using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSUTEMP.Migrations
{
    /// <inheritdoc />
    public partial class Dummy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrailNote_Trail_TrailId",
                table: "TrailNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrailNote",
                table: "TrailNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trail",
                table: "Trail");

            migrationBuilder.RenameTable(
                name: "TrailNote",
                newName: "TrailNotes");

            migrationBuilder.RenameTable(
                name: "Trail",
                newName: "Trails");

            migrationBuilder.RenameIndex(
                name: "IX_TrailNote_TrailId",
                table: "TrailNotes",
                newName: "IX_TrailNotes_TrailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrailNotes",
                table: "TrailNotes",
                column: "NoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trails",
                table: "Trails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrailNotes_Trails_TrailId",
                table: "TrailNotes",
                column: "TrailId",
                principalTable: "Trails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrailNotes_Trails_TrailId",
                table: "TrailNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trails",
                table: "Trails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrailNotes",
                table: "TrailNotes");

            migrationBuilder.RenameTable(
                name: "Trails",
                newName: "Trail");

            migrationBuilder.RenameTable(
                name: "TrailNotes",
                newName: "TrailNote");

            migrationBuilder.RenameIndex(
                name: "IX_TrailNotes_TrailId",
                table: "TrailNote",
                newName: "IX_TrailNote_TrailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trail",
                table: "Trail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrailNote",
                table: "TrailNote",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrailNote_Trail_TrailId",
                table: "TrailNote",
                column: "TrailId",
                principalTable: "Trail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

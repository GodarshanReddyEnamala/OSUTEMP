using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSUTEMP.Migrations
{
    /// <inheritdoc />
    public partial class Add_IsActive_Column_To_TrailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Trail",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Trail");
        }
    }
}

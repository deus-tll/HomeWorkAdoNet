using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Championship_DatabaseContext.Migrations
{
    /// <inheritdoc />
    public partial class AddInfoAboutGoals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfGoalsScored",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfMissedGoals",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfGoalsScored",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "NumberOfMissedGoals",
                table: "Teams");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Championship_DatabaseContext.Migrations
{
    /// <inheritdoc />
    public partial class CreateChampionshipDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfWins = table.Column<int>(type: "int", nullable: false),
                    NumberOfDefeats = table.Column<int>(type: "int", nullable: false),
                    NumberOfDraws = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}

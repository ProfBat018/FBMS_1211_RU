using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetAzWebApi.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThemeCount",
                table: "Chapters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThemeCount",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

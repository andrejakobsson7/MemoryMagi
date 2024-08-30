using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class NySeedaddata240830 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 1,
                column: "name",
                value: "Goda frukter");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 2,
                column: "name",
                value: "18+ drinkar");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 3,
                column: "name",
                value: "Djur på bonnagården");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 4,
                column: "name",
                value: "Bilar man hade velat ha");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Games");
        }
    }
}

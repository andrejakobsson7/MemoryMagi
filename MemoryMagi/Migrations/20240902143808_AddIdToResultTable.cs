using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToResultTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Results_user_id",
                table: "Results",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_user_id",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Results");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                columns: new[] { "user_id", "game_id", "date_played" });
        }
    }
}

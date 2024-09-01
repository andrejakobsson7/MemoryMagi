using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class EnableMultipleUserResultsPerGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Results_2",
                table: "Results_2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_played",
                table: "Results_2",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results_2",
                table: "Results_2",
                columns: new[] { "user_id", "game_id", "date_played" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Results_2",
                table: "Results_2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "date_played",
                table: "Results_2",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results_2",
                table: "Results_2",
                columns: new[] { "user_id", "game_id" });
        }
    }
}

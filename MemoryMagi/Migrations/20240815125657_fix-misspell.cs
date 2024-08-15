using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class fixmisspell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersItems",
                table: "UsersItems");

            migrationBuilder.RenameTable(
                name: "UsersItems",
                newName: "UserItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserItems",
                table: "UserItems",
                columns: new[] { "user_id", "item_id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserItems",
                table: "UserItems");

            migrationBuilder.RenameTable(
                name: "UserItems",
                newName: "UsersItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersItems",
                table: "UsersItems",
                columns: new[] { "user_id", "item_id" });
        }
    }
}

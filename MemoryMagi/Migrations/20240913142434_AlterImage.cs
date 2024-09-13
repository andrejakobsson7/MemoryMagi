using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class AlterImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 35,
                column: "image",
                value: "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/1500x1500/products/87964/89908/The-Flash-DC-Comics-Lifesize-Cardboard-Cutout-available-now-at-starstills__31957.1474976928.jpg?c=2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 35,
                column: "image",
                value: "https://static.wikia.nocookie.net/heroes-and-villain/images/a/a2/Profile_-_Wally_West.png/revision/latest?cb=20220610164521");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "name", "user_id" },
                values: new object[,]
                {
                    { 1, "Frukt", null },
                    { 2, "Alkohol", null },
                    { 3, "Djur", null },
                    { 4, "Bilar", null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "id", "category_id", "image", "name" },
                values: new object[,]
                {
                    { 1, 1, "images/Apples.jpg", "Äpple" },
                    { 2, 1, "images/Pasta.jpg", "Pasta" },
                    { 3, 1, "images/Pineapple.jpg", "Ananas" },
                    { 4, 1, "images/Pumpkins.jpg", "Pumpa" },
                    { 5, 1, "images/Starwberries.jpg", "Jordgubbar" },
                    { 6, 1, "images/Fish.jpg", "Fisk" },
                    { 7, 2, "images/Beer.jpg", "Öl" },
                    { 8, 2, "images/Cocktail.jpg", "Cocktail" },
                    { 9, 2, "images/Crafted_beer.jpg", "Crafted öl" },
                    { 10, 2, "images/Red_Wine.jpg", "Rött vin" },
                    { 11, 2, "images/Wine.jpg", "Vin" },
                    { 12, 3, "images/Bird.jpg", "Fågel" },
                    { 13, 3, "images/Cat.jpg", "Katt" },
                    { 14, 3, "images/Cows.jpg", "Ko" },
                    { 15, 3, "images/Lion.jpg", "Lejon" },
                    { 16, 3, "images/Monkeys.jpg", "Apa" },
                    { 17, 3, "images/Wolf.jpg", "Varg" },
                    { 18, 4, "images/Exoticc_car.jpg", "Cool bil" },
                    { 19, 4, "images/Pastawagon_car.jpg", "Pasta bilen" },
                    { 20, 4, "images/Racecar_car.jpg", "Racer bilen" },
                    { 21, 4, "images/SUV_car.jpg", "Stadsjeepen" },
                    { 22, 4, "images/Trackcar_car.jpg", "Ban bilen" },
                    { 23, 4, "images/Veteran_car.jpg", "Veteran bilen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}

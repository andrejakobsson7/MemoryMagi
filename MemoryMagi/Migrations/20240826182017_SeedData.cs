using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories_2",
                columns: new[] { "id", "image_url", "name" },
                values: new object[,]
                {
                    { 1, "images/Veteran_car.jpg", "Frukt" },
                    { 2, "images/Veteran_car.jpg", "Alkohol" },
                    { 3, "images/Veteran_car.jpg", "Djur" },
                    { 4, "images/Veteran_car.jpg", "Bilar" }
                });

            migrationBuilder.InsertData(
                table: "DifficultyLevels_2",
                columns: new[] { "id", "level", "name", "nr_of_cards" },
                values: new object[,]
                {
                    { 1, 1, "Lätt", 4 },
                    { 2, 2, "Medium", 8 },
                    { 3, 3, "Svår", 15 }
                });

            migrationBuilder.InsertData(
                table: "GameTypes_2",
                columns: new[] { "id", "game_type", "name" },
                values: new object[,]
                {
                    { 1, 1, "Public" },
                    { 2, 2, "Private" }
                });

            migrationBuilder.InsertData(
                table: "Games_2",
                columns: new[] { "id", "category_id", "created_by", "difficulty_level_id", "game_type_id" },
                values: new object[,]
                {
                    { 1, 1, null, 1, 1 },
                    { 2, 2, null, 2, 1 },
                    { 3, 3, null, 3, 1 },
                    { 4, 4, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Items_2",
                columns: new[] { "id", "game_id", "image", "name" },
                values: new object[,]
                {
                    { 1, 1, "images/Apples.jpg", "Äpple" },
                    { 2, 1, "images/Pasta.jpg", "Pasta" },
                    { 3, 1, "images/Pineapple.jpg", "Ananas" },
                    { 4, 1, "images/Pumpkins.jpg", "Pumpa" },
                    { 5, 1, "images/Strawberries.jpg", "Jordgubbar" },
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
                    { 18, 4, "images/Exotic_car.jpg", "Cool bil" },
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
                table: "GameTypes_2",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items_2",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories_2",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories_2",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories_2",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories_2",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels_2",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels_2",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels_2",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameTypes_2",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "name", "user_id", "image_url" },
                values: new object[,]
                {
                    { 1, "Frukt", null, "images/Veteran_car.jpg" },
                    { 2, "Alkohol", null, "images/Veteran_car.jpg" },
                    { 3, "Djur", null, "images/Veteran_car.jpg" },
                    { 4, "Bilar", null, "images/Veteran_car.jpg" }
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
    }
}

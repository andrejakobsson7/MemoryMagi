using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class seedaBilder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);

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

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Mycket bra jobbat, du är på god väg!", "Klarat första spelet!" },
                    { 2, "Du är duktig, kämpa på!", "Du har klarat andra spelet!" },
                    { 3, "Du klarade precis den lättaste nivån, kämpa på och försök klara nästa nivå!", "Du klarade den första \"lätt\" nivån!" },
                    { 4, "Din första vinst! Fortsätt att vinna och nå toppen!", "Första vinsten!" },
                    { 5, "Du har tagit de första stegen mot att bli en mästare. Fortsätt så!", "Mästarens start!" },
                    { 6, "Bra jobbat! Nu har du klarat medelnivån, sikta på nästa!", "Du klarade den \"medel\" nivån!" },
                    { 7, "Du fick perfekt poäng! Imponerande arbete!", "Första perfekta poäng!" },
                    { 8, "Du har klarat fler än 10 spel! En riktig veteran!", "Fler än 10 spel klara!" },
                    { 9, "Du har satt rekord för snabbaste tiden! Otroligt snabb!", "Snabbaste tiden!" },
                    { 10, "Fantastiskt! Du har klarat hela spelet! En prestation att vara stolt över!", "Avklarat hela spelet!" }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "image",
                value: "https://t3.ftcdn.net/jpg/03/32/90/64/360_F_332906430_twMd1O5wBgh2cJMFW738ATdedEcJYbiI.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "image",
                value: "https://thumbs.dreamstime.com/b/plate-uncooked-pasta-fork-14167296.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "image",
                value: "https://t3.ftcdn.net/jpg/00/91/91/28/360_F_91912805_ulNEUfKTmE4VFFnTk3s0cKAxaWfKNZJ8.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "image",
                value: "https://cdn.pixabay.com/photo/2023/12/03/06/35/pumpkin-8426960_1280.png");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "image",
                value: "https://static.vecteezy.com/system/resources/thumbnails/030/195/033/original/animated-forming-strawberries-on-a-white-background-free-video.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6,
                column: "image",
                value: "https://st2.depositphotos.com/2664341/11886/v/950/depositphotos_118860428-stock-illustration-clown-fish-cartoon.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "image_url", "name" },
                values: new object[] { 2, "images/Veteran_car.jpg", "Alkohol" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "image",
                value: "images/Apples.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "image",
                value: "images/Pasta.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "image",
                value: "images/Pineapple.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "image",
                value: "images/Pumpkins.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "image",
                value: "images/Strawberries.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6,
                column: "image",
                value: "images/Fish.jpg");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "id", "game_id", "image", "name" },
                values: new object[,]
                {
                    { 7, 2, "images/Beer.jpg", "Öl" },
                    { 8, 2, "images/Cocktail.jpg", "Cocktail" },
                    { 9, 2, "images/Crafted_beer.jpg", "Crafted öl" },
                    { 10, 2, "images/Red_Wine.jpg", "Rött vin" },
                    { 11, 2, "images/Wine.jpg", "Vin" }
                });
        }
    }
}

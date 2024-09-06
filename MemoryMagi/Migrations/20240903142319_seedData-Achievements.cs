using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class seedDataAchievements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

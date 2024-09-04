using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class seedadebilduro1433 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 13,
                column: "image",
                value: "https://img.freepik.com/premium-vector/cute-cat-collection-isolated-white-background_703032-4100.jpg?w=1380");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 14,
                column: "image",
                value: "https://img.freepik.com/premium-vector/cartoon-illustration-brown-white-cow_1216680-373.jpg?w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 15,
                column: "image",
                value: "https://img.freepik.com/premium-vector/cute-lion-cartoon-white-background_29190-8567.jpg?w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 16,
                column: "image",
                value: "https://img.freepik.com/free-vector/monkey-cartoon-character-sticker_1308-76562.jpg?t=st=1725442733~exp=1725446333~hmac=261a58dc78d31af291802ee3e0912fd5f2f294d1d32da3a27fb91b75c6f30dfe&w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 17,
                column: "image",
                value: "https://img.freepik.com/premium-vector/cartoon-dog-with-cartoon-face-word-wolf-it_1025542-56600.jpg?w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/premium-vector/red-car-with-license-plate-number-3_1128391-17709.jpg?w=740", "sport bil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/free-vector/boy-driving-vintage-car-cartoon-design_1308-107242.jpg?t=st=1725453109~exp=1725456709~hmac=81d598da00b7fdb14f45c280734502f48e4d747188fd295ce35c102627bb0ad4&w=1800", "cabriolet bilen" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 20,
                column: "image",
                value: "https://img.freepik.com/premium-vector/indy-car-speeding-f1-racing-f1-sports-car-illustration-vector_280080-22.jpg?w=1380,");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 21,
                column: "image",
                value: "https://img.freepik.com/premium-vector/red-car-with-surfboard-top-it_1013341-387239.jpg?w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-background_1308-75583.jpg?t=st=1725452945~exp=1725456545~hmac=961c6db37d955480177b2eb6d6c6b7571efb30f5ff94d5fdd41dcc65c2c28521&w=1380", "Sedan bilen" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 23,
                column: "image",
                value: "https://img.freepik.com/free-vector/classic-green-vintage-car-illustration_1308-164648.jpg?t=st=1725452987~exp=1725456587~hmac=dc808c875da97d90cb4641fdebe8f6718e4ff0dab6cb8aab516ef3495ffdb0f8&w=1380");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 13,
                column: "image",
                value: "images/Cat.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 14,
                column: "image",
                value: "images/Cows.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 15,
                column: "image",
                value: "images/Lion.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 16,
                column: "image",
                value: "images/Monkeys.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 17,
                column: "image",
                value: "images/Wolf.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "image", "name" },
                values: new object[] { "images/Exotic_car.jpg", "Cool bil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "image", "name" },
                values: new object[] { "images/Pastawagon_car.jpg", "Pasta bilen" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 20,
                column: "image",
                value: "images/Racecar_car.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 21,
                column: "image",
                value: "images/SUV_car.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "image", "name" },
                values: new object[] { "images/Trackcar_car.jpg", "Ban bilen" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 23,
                column: "image",
                value: "images/Veteran_car.jpg");
        }
    }
}

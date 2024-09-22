using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class bilder_till_kategorier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                column: "image_url",
                value: "https://i.dietdoctor.com/se/wp-content/2019/10/Fruits-and-vegetables-guide.jpg?auto=compress%2Cformat&w=1200&h=800&fit=crop");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                column: "image_url",
                value: "https://img.pixers.pics/pho_wat(s3:700/FO/57/06/50/45/700_FO57065045_3947f9ea6db6ffee13e8d6526c4b092f.jpg,700,700,cms:2018/10/5bd1b6b8d04b8_220x50-watermark.png,over,480,650,jpg)/posters-vilda-djur-pa-cartoon-jungle-jungle-vilda-djur.jpg.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                column: "image_url",
                value: "https://sohu-shop.se/images/wallstickers/wallstickers-med-catoon-biler.webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                column: "image_url",
                value: "images/Veteran_car.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                column: "image_url",
                value: "images/Veteran_car.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                column: "image_url",
                value: "images/Veteran_car.jpg");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class seedabilder1132 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "image",
                value: "https://img.freepik.com/free-vector/sticker-design-with-apple-isolated_1308-66383.jpg?t=st=1725441600~exp=1725445200~hmac=2b353ba4b82a3ad64efda6bf389b2541f080abace5c4b2650920cfd765f9e236&w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "image",
                value: "https://img.freepik.com/free-vector/spaghetti-pasta-with-bolognese-sauce_1308-115408.jpg?t=st=1725441659~exp=1725445259~hmac=cae2d1c081992be7f9b2697d6df20e9ffeb560de7546c7f8be2f602197921472&w=1380");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "image",
                value: "https://img.freepik.com/premium-vector/drawing-pineapple-with-green-top-yellow-top_1166763-24137.jpg?w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "image",
                value: "https://img.freepik.com/free-vector/fresh-pumpkin-white-b_1308-39708.jpg?t=st=1725442167~exp=1725445767~hmac=906c103466192496ecf2b6a977843c6c7588c65e5eb49bb89ee2da4a571bbf55&w=826");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "image",
                value: "https://img.freepik.com/premium-vector/strawberry-clipart-vector-illustration-white-background_1280610-709.jpg?w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6,
                column: "image",
                value: "https://img.freepik.com/premium-vector/cartoon-illustration-smiling-orange-white-clownfish_1216680-928.jpg?w=740");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 12,
                column: "image",
                value: "https://img.freepik.com/free-vector/hand-drawn-flat-design-robin-collection_23-2149145170.jpg?t=st=1725442349~exp=1725445949~hmac=e0c69eb898156b90b344b8315ad7f4c468d28130b0d358eb7ba220eafc748e98&w=740");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 12,
                column: "image",
                value: "images/Bird.jpg");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class AlterImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 28,
                column: "image",
                value: "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/original/products/1038/1663/2366_IronMan_AvengersAssemble_40__71309.1608072851.jpg?c=1");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 29,
                column: "image",
                value: "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/original/products/1039/1633/2367_CaptainAmerica_AvengersAssemble_46__81672.1608071746.jpg?c=1");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 30,
                column: "image",
                value: "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/original/products/1040/1678/2368_Thor_AvengersAssemble_40__24328.1608073129.jpg?c=1");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 31,
                column: "image",
                value: "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/1060x1060/products/1136/1672/2481_Spider-Man_2017_40__97689.1608073067.jpg?c=1");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 32,
                column: "image",
                value: "https://m.media-amazon.com/images/S/pv-target-images/9fd172a452587004a54251df846efdb16b3f2e808718c9dca35fe7ff68f508ac._SX1080_FMjpg_.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 33,
                column: "image",
                value: "https://cdn.flickeringmyth.com/wp-content/uploads/2021/09/superman-blu-ray-1629903679988.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 34,
                column: "image",
                value: "https://experiencethewonder.com/wp-content/uploads/2004/06/2004-WBCP-Justice-League-Unlimited-Animated-Style-Guide-Wonder-Woman-010.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 35,
                column: "image",
                value: "https://static.wikia.nocookie.net/heroes-and-villain/images/a/a2/Profile_-_Wally_West.png/revision/latest?cb=20220610164521");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 28,
                column: "image",
                value: "https://static.wikia.nocookie.net/p__/images/d/df/Iron_Man_Mk_L_2.png/revision/latest?cb=20151218034339&path-prefix=protagonist");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 29,
                column: "image",
                value: "https://static.wikia.nocookie.net/thedailybugle/images/0/02/Captain_America_Cap.png/revision/latest?cb=20150629095627");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 30,
                column: "image",
                value: "https://static.wikia.nocookie.net/vsdebating/images/c/c3/3803806155thorcartoonpngavengersassemblethordrawingclipart.png/revision/latest?cb=20220217033844");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 31,
                column: "image",
                value: "https://static.wikia.nocookie.net/thedailybugle/images/2/2b/Ultimate_Spider_Man_Render.png/revision/latest?cb=20160319202253");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 32,
                column: "image",
                value: "https://static.wikia.nocookie.net/vsdebating/images/b/b4/BatmanTAS.png/revision/latest?cb=20220406015822");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 33,
                column: "image",
                value: "https://static.wikia.nocookie.net/p__/images/3/36/Superman_DCAU_004.png/revision/latest?cb=20210809205037&path-prefix=protagonist");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 34,
                column: "image",
                value: "https://static.wikia.nocookie.net/p__/images/d/dc/Wonder_Woman_%28DCAU%29_Render.png/revision/latest?cb=20220706195658&path-prefix=protagonist");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 35,
                column: "image",
                value: "https://static.wikia.nocookie.net/p__/images/e/e9/The_Flash_%28DCAU%29.png/revision/latest?cb=20190122131230&path-prefix=protagonist");
        }
    }
}

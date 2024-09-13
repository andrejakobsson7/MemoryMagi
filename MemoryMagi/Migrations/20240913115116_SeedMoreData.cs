using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                column: "image_url",
                value: "https://img.pixers.pics/pho_wat(s3:700/FO/53/42/44/83/700_FO53424483_d7f9c14e67bdba97211d5192a12e242c.jpg,700,654,cms:2018/10/5bd1b6b8d04b8_220x50-watermark.png,over,480,604,jpg)/posters-bar-frukt-grupp-tecknad-illustration.jpg.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                column: "image_url",
                value: "https://img.pixers.pics/pho_wat(s3:700/FO/63/25/91/96/700_FO63259196_e707a3a294a157465cac9e30e69ed23c.jpg,700,648,cms:2018/10/5bd1b6b8d04b8_220x50-watermark.png,over,480,598,jpg)/posters-grattis-safari-djur-tecknad.jpg.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                column: "image_url",
                value: "https://thumbs.dreamstime.com/b/kawaii-cute-cars-sticker-image-style-art-meme-animated-gifs-isolated-white-background-ai-generated-png-283486842.jpg");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "image_url", "name" },
                values: new object[] { 4, "https://t3.ftcdn.net/jpg/06/11/65/14/360_F_611651420_EgCnaCL6KDm3ukuMNmecVkaCHcfmbO6u.jpg", "Superhjältar" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/premium-vector/drawing-pineapple-with-green-top-yellow-top_1166763-24137.jpg?w=740", "Ananas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/premium-vector/strawberry-clipart-vector-illustration-white-background_1280610-709.jpg?w=740", "Jordgubbar" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "image", "name" },
                values: new object[] { "https://static.vecteezy.com/ti/gratis-vektor/p3/19862411-ljuv-hallon-ikon-klamma-konst-vektor-illustration-i-tecknad-serie-animering-frukt-och-vegetabiliska-vector.jpg", "Hallon" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 3, "https://img.freepik.com/free-vector/hand-drawn-flat-design-robin-collection_23-2149145170.jpg?t=st=1725442349~exp=1725445949~hmac=e0c69eb898156b90b344b8315ad7f4c468d28130b0d358eb7ba220eafc748e98&w=740", "Fågel" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 3, "https://img.freepik.com/premium-vector/cute-cat-collection-isolated-white-background_703032-4100.jpg?w=1380", "Katt" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "image", "name" },
                values: new object[] { "https://static.vecteezy.com/ti/gratis-vektor/p3/6325976-elefant-tecknad-fargad-clipart-illustration-gratis-vector.jpg", "Elefant" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 4, "https://img.freepik.com/premium-vector/red-car-with-license-plate-number-3_1128391-17709.jpg?w=740", "Sportbil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 4, "https://img.freepik.com/free-vector/boy-driving-vintage-car-cartoon-design_1308-107242.jpg?t=st=1725453109~exp=1725456709~hmac=81d598da00b7fdb14f45c280734502f48e4d747188fd295ce35c102627bb0ad4&w=1800", "Cabriolet" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtZSSxfN4KGqrhe4o4hCapFOKvmmfN9EJL1g&s", "Racerbil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 4, "https://img.freepik.com/premium-vector/red-car-with-surfboard-top-it_1013341-387239.jpg?w=740", "Stadsjeep" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 4, "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-background_1308-75583.jpg?t=st=1725452945~exp=1725456545~hmac=961c6db37d955480177b2eb6d6c6b7571efb30f5ff94d5fdd41dcc65c2c28521&w=1380", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/free-vector/classic-green-vintage-car-illustration_1308-164648.jpg?t=st=1725452987~exp=1725456587~hmac=dc808c875da97d90cb4641fdebe8f6718e4ff0dab6cb8aab516ef3495ffdb0f8&w=1380", "Veteranbil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "image", "name" },
                values: new object[] { "https://e7.pngegg.com/pngimages/699/627/png-clipart-black-batman-batmobile-illustration-batman-batmobile-superhero-drawing-cartoon-car-mammal-heroes.png", "Batmobil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "image", "name" },
                values: new object[] { "https://media.istockphoto.com/id/508838370/sv/vektor/golf-cart-with-shadow.jpg?s=612x612&w=0&k=20&c=OYJWkcZXA2X0Q0ubspPWSnG55go2VMu_lEnvCAVSHUU=", "Golfbil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "image", "name" },
                values: new object[] { "https://static.vecteezy.com/system/resources/thumbnails/021/514/981/small_2x/van-car-cartoon-icon-illustration-vehicle-transportation-icon-concept-isolated-premium-flat-cartoon-style-vector.jpg", "Van" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "image", "name" },
                values: new object[] { "https://thumbs.dreamstime.com/b/ford-mustangfastback-1965-28658306.jpg", "Muskelbil" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "image", "name" },
                values: new object[] { "https://images.squarespace-cdn.com/content/v1/6598c8e83ff0af0197ff19f9/1709281356076-X4X5JKNF1FDD50SKVD0D/1981-delorean-back-to-the-future-_0008_9.jpg", "Framtidsbil" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "id", "game_id", "image", "name" },
                values: new object[,]
                {
                    { 7, 3, "https://img.freepik.com/premium-vector/cartoon-illustration-brown-white-cow_1216680-373.jpg?w=740", "Ko" },
                    { 8, 3, "https://img.freepik.com/premium-vector/cute-lion-cartoon-white-background_29190-8567.jpg?w=740", "Lejon" },
                    { 9, 3, "https://img.freepik.com/free-vector/monkey-cartoon-character-sticker_1308-76562.jpg?t=st=1725442733~exp=1725446333~hmac=261a58dc78d31af291802ee3e0912fd5f2f294d1d32da3a27fb91b75c6f30dfe&w=740", "Apa" },
                    { 10, 3, "https://img.freepik.com/premium-vector/cartoon-dog-with-cartoon-face-word-wolf-it_1025542-56600.jpg?w=740", "Varg" },
                    { 11, 3, "https://static.vecteezy.com/ti/gratis-vektor/p3/12507322-sot-kanin-tecknad-serie-pa-vit-bakgrund-vector.jpg", "Kanin" },
                    { 24, 4, "https://m.media-amazon.com/images/I/71zkRuxSezL._AC_UF894,1000_QL80_.jpg", "Ghostbusters-bil" },
                    { 25, 4, "https://static.vecteezy.com/ti/gratis-vektor/p1/2687298-monster-truck-cartoon-vehicle-or-car-and-extreme-show-transport-illustration-vector.jpg", "Monstertruck" },
                    { 26, 4, "https://images.all-free-download.com/images/graphiclarge/mr_bean_s_car_in_mr_bean_cartoon_movie_icon_flat_handdrawn_classic_sketch_6926445.jpg", "Mr. Beans bil" },
                    { 27, 4, "https://www.shutterstock.com/shutterstock/photos/1213775323/display_1500/stock-vector-vector-layout-of-an-suv-hummer-1213775323.jpg", "Hummer" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "id", "category_id", "created_by", "difficulty_level_id", "game_type", "name" },
                values: new object[,]
                {
                    { 2, 4, null, 1, "public", "Marvel" },
                    { 5, 4, null, 1, "public", "DC" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "id", "game_id", "image", "name" },
                values: new object[,]
                {
                    { 28, 2, "https://static.wikia.nocookie.net/p__/images/d/df/Iron_Man_Mk_L_2.png/revision/latest?cb=20151218034339&path-prefix=protagonist", "Iron Man" },
                    { 29, 2, "https://static.wikia.nocookie.net/thedailybugle/images/0/02/Captain_America_Cap.png/revision/latest?cb=20150629095627", "Captain America" },
                    { 30, 2, "https://static.wikia.nocookie.net/vsdebating/images/c/c3/3803806155thorcartoonpngavengersassemblethordrawingclipart.png/revision/latest?cb=20220217033844", "Thor" },
                    { 31, 2, "https://static.wikia.nocookie.net/thedailybugle/images/2/2b/Ultimate_Spider_Man_Render.png/revision/latest?cb=20160319202253", "Spider-Man" },
                    { 32, 5, "https://static.wikia.nocookie.net/vsdebating/images/b/b4/BatmanTAS.png/revision/latest?cb=20220406015822", "Batman" },
                    { 33, 5, "https://static.wikia.nocookie.net/p__/images/3/36/Superman_DCAU_004.png/revision/latest?cb=20210809205037&path-prefix=protagonist", "Superman" },
                    { 34, 5, "https://static.wikia.nocookie.net/p__/images/d/dc/Wonder_Woman_%28DCAU%29_Render.png/revision/latest?cb=20220706195658&path-prefix=protagonist", "Wonder Woman" },
                    { 35, 5, "https://static.wikia.nocookie.net/p__/images/e/e9/The_Flash_%28DCAU%29.png/revision/latest?cb=20190122131230&path-prefix=protagonist", "The Flash" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4);

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

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/free-vector/spaghetti-pasta-with-bolognese-sauce_1308-115408.jpg?t=st=1725441659~exp=1725445259~hmac=cae2d1c081992be7f9b2697d6df20e9ffeb560de7546c7f8be2f602197921472&w=1380", "Pasta" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/premium-vector/drawing-pineapple-with-green-top-yellow-top_1166763-24137.jpg?w=740", "Ananas" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/free-vector/fresh-pumpkin-white-b_1308-39708.jpg?t=st=1725442167~exp=1725445767~hmac=906c103466192496ecf2b6a977843c6c7588c65e5eb49bb89ee2da4a571bbf55&w=826", "Pumpa" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 1, "https://img.freepik.com/premium-vector/strawberry-clipart-vector-illustration-white-background_1280610-709.jpg?w=740", "Jordgubbar" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 1, "https://img.freepik.com/premium-vector/cartoon-illustration-smiling-orange-white-clownfish_1216680-928.jpg?w=740", "Fisk" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/free-vector/hand-drawn-flat-design-robin-collection_23-2149145170.jpg?t=st=1725442349~exp=1725445949~hmac=e0c69eb898156b90b344b8315ad7f4c468d28130b0d358eb7ba220eafc748e98&w=740", "Fågel" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 3, "https://img.freepik.com/premium-vector/cute-cat-collection-isolated-white-background_703032-4100.jpg?w=1380", "Katt" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 3, "https://img.freepik.com/premium-vector/cartoon-illustration-brown-white-cow_1216680-373.jpg?w=740", "Ko" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 3, "https://img.freepik.com/premium-vector/cute-lion-cartoon-white-background_29190-8567.jpg?w=740", "Lejon" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 3, "https://img.freepik.com/free-vector/monkey-cartoon-character-sticker_1308-76562.jpg?t=st=1725442733~exp=1725446333~hmac=261a58dc78d31af291802ee3e0912fd5f2f294d1d32da3a27fb91b75c6f30dfe&w=740", "Apa" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "game_id", "image", "name" },
                values: new object[] { 3, "https://img.freepik.com/premium-vector/cartoon-dog-with-cartoon-face-word-wolf-it_1025542-56600.jpg?w=740", "Varg" });

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
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/premium-vector/indy-car-speeding-f1-racing-f1-sports-car-illustration-vector_280080-22.jpg?w=1380,", "Racer bilen" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/premium-vector/red-car-with-surfboard-top-it_1013341-387239.jpg?w=740", "Stadsjeepen" });

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
                columns: new[] { "image", "name" },
                values: new object[] { "https://img.freepik.com/free-vector/classic-green-vintage-car-illustration_1308-164648.jpg?t=st=1725452987~exp=1725456587~hmac=dc808c875da97d90cb4641fdebe8f6718e4ff0dab6cb8aab516ef3495ffdb0f8&w=1380", "Veteran bilen" });
        }
    }
}

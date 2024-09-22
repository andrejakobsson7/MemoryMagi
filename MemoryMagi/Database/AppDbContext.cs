using MemoryMagi.Models;
using MemoryMagi.Models._2._0;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Database
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<ResultModel> Results { get; set; }
        public DbSet<DifficultyLevelModel> DifficultyLevels { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<AchievementModel> Achievements { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }
        public DbSet<AllowedUser> AllowedUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ItemModel>().HasData(
            // Game-id: 1 - Frukt (Lätt) 4 kort
            new ItemModel
            {
                Id = 1,
                Name = "Äpple",
                Image = "https://img.freepik.com/free-vector/sticker-design-with-apple-isolated_1308-66383.jpg?t=st=1725441600~exp=1725445200~hmac=2b353ba4b82a3ad64efda6bf389b2541f080abace5c4b2650920cfd765f9e236&w=740",
                GameId = 1
            },
            new ItemModel
            {
                Id = 2,
                Name = "Ananas",
                Image = "https://img.freepik.com/premium-vector/drawing-pineapple-with-green-top-yellow-top_1166763-24137.jpg?w=740",
                GameId = 1
            },
            new ItemModel
            {
                Id = 3,
                Name = "Jordgubbar",
                Image = "https://img.freepik.com/premium-vector/strawberry-clipart-vector-illustration-white-background_1280610-709.jpg?w=740",
                GameId = 1
            },
            new ItemModel
            {
                Id = 4,
                Name = "Hallon",
                Image = "https://static.vecteezy.com/ti/gratis-vektor/p3/19862411-ljuv-hallon-ikon-klamma-konst-vektor-illustration-i-tecknad-serie-animering-frukt-och-vegetabiliska-vector.jpg",
                GameId = 1
            },
            // GameId 3 Djur på bonnagården: Djur (Medium) 8 kort
            new ItemModel
            {
                Id = 5,
                Name = "Fågel",
                Image = "https://img.freepik.com/free-vector/hand-drawn-flat-design-robin-collection_23-2149145170.jpg?t=st=1725442349~exp=1725445949~hmac=e0c69eb898156b90b344b8315ad7f4c468d28130b0d358eb7ba220eafc748e98&w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 6,
                Name = "Katt",
                Image = "https://img.freepik.com/premium-vector/cute-cat-collection-isolated-white-background_703032-4100.jpg?w=1380",
                GameId = 3
            },
            new ItemModel
            {
                Id = 7,
                Name = "Ko",
                Image = "https://img.freepik.com/premium-vector/cartoon-illustration-brown-white-cow_1216680-373.jpg?w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 8,
                Name = "Lejon",
                Image = "https://img.freepik.com/premium-vector/cute-lion-cartoon-white-background_29190-8567.jpg?w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 9,
                Name = "Apa",
                Image = "https://img.freepik.com/free-vector/monkey-cartoon-character-sticker_1308-76562.jpg?t=st=1725442733~exp=1725446333~hmac=261a58dc78d31af291802ee3e0912fd5f2f294d1d32da3a27fb91b75c6f30dfe&w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 10,
                Name = "Varg",
                Image = "https://img.freepik.com/premium-vector/cartoon-dog-with-cartoon-face-word-wolf-it_1025542-56600.jpg?w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 11,
                Name = "Kanin",
                Image = "https://static.vecteezy.com/ti/gratis-vektor/p3/12507322-sot-kanin-tecknad-serie-pa-vit-bakgrund-vector.jpg",
                GameId = 3
            },
            new ItemModel
            {
                Id = 12,
                Name = "Elefant",
                Image = "https://static.vecteezy.com/ti/gratis-vektor/p3/6325976-elefant-tecknad-fargad-clipart-illustration-gratis-vector.jpg",
                GameId = 3
            },
            // GameId 4 Bilar man hade velat ha: Bilar (Svår) 15 kort
            new ItemModel
            {
                Id = 13,
                Name = "Sportbil",
                Image = "https://img.freepik.com/premium-vector/red-car-with-license-plate-number-3_1128391-17709.jpg?w=740",
                GameId = 4
            },
            new ItemModel
            {
                Id = 14,
                Name = "Cabriolet",
                Image = "https://img.freepik.com/free-vector/boy-driving-vintage-car-cartoon-design_1308-107242.jpg?t=st=1725453109~exp=1725456709~hmac=81d598da00b7fdb14f45c280734502f48e4d747188fd295ce35c102627bb0ad4&w=1800",
                GameId = 4
            },
            new ItemModel
            {
                Id = 15,
                Name = "Racerbil",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtZSSxfN4KGqrhe4o4hCapFOKvmmfN9EJL1g&s",
                GameId = 4
            },
            new ItemModel
            {
                Id = 16,
                Name = "Stadsjeep",
                Image = "https://img.freepik.com/premium-vector/red-car-with-surfboard-top-it_1013341-387239.jpg?w=740",
                GameId = 4
            },
            new ItemModel
            {
                Id = 17,
                Name = "Sedan",
                Image = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-background_1308-75583.jpg?t=st=1725452945~exp=1725456545~hmac=961c6db37d955480177b2eb6d6c6b7571efb30f5ff94d5fdd41dcc65c2c28521&w=1380",
                GameId = 4
            },
            new ItemModel
            {
                Id = 18,
                Name = "Veteranbil",
                Image = "https://img.freepik.com/free-vector/classic-green-vintage-car-illustration_1308-164648.jpg?t=st=1725452987~exp=1725456587~hmac=dc808c875da97d90cb4641fdebe8f6718e4ff0dab6cb8aab516ef3495ffdb0f8&w=1380",
                GameId = 4
            },
            new ItemModel
            {
                Id = 19,
                Name = "Batmobil",
                Image = "https://e7.pngegg.com/pngimages/699/627/png-clipart-black-batman-batmobile-illustration-batman-batmobile-superhero-drawing-cartoon-car-mammal-heroes.png",
                GameId = 4
            },
            new ItemModel
            {
                Id = 20,
                Name = "Golfbil",
                Image = "https://media.istockphoto.com/id/508838370/sv/vektor/golf-cart-with-shadow.jpg?s=612x612&w=0&k=20&c=OYJWkcZXA2X0Q0ubspPWSnG55go2VMu_lEnvCAVSHUU=",
                GameId = 4
            },
            new ItemModel
            {
                Id = 21,
                Name = "Van",
                Image = "https://static.vecteezy.com/system/resources/thumbnails/021/514/981/small_2x/van-car-cartoon-icon-illustration-vehicle-transportation-icon-concept-isolated-premium-flat-cartoon-style-vector.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 22,
                Name = "Muskelbil",
                Image = "https://thumbs.dreamstime.com/b/ford-mustangfastback-1965-28658306.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 23,
                Name = "Framtidsbil",
                Image = "https://images.squarespace-cdn.com/content/v1/6598c8e83ff0af0197ff19f9/1709281356076-X4X5JKNF1FDD50SKVD0D/1981-delorean-back-to-the-future-_0008_9.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 24,
                Name = "Ghostbusters-bil",
                Image = "https://m.media-amazon.com/images/I/71zkRuxSezL._AC_UF894,1000_QL80_.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 25,
                Name = "Monstertruck",
                Image = "https://static.vecteezy.com/ti/gratis-vektor/p1/2687298-monster-truck-cartoon-vehicle-or-car-and-extreme-show-transport-illustration-vector.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 26,
                Name = "Mr. Beans bil",
                Image = "https://images.all-free-download.com/images/graphiclarge/mr_bean_s_car_in_mr_bean_cartoon_movie_icon_flat_handdrawn_classic_sketch_6926445.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 27,
                Name = "Hummer",
                Image = "https://www.shutterstock.com/shutterstock/photos/1213775323/display_1500/stock-vector-vector-layout-of-an-suv-hummer-1213775323.jpg",
                GameId = 4
            },
            //GameId 2 Marvel: Superhjältar (Lätt) 4 kort
            new ItemModel
            {
                Id = 28,
                Name = "Iron Man",
                Image = "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/original/products/1038/1663/2366_IronMan_AvengersAssemble_40__71309.1608072851.jpg?c=1",
                GameId = 2
            },
            new ItemModel
            {
                Id = 29,
                Name = "Captain America",
                Image = "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/original/products/1039/1633/2367_CaptainAmerica_AvengersAssemble_46__81672.1608071746.jpg?c=1",
                GameId = 2
            },
            new ItemModel
            {
                Id = 30,
                Name = "Thor",
                Image = "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/original/products/1040/1678/2368_Thor_AvengersAssemble_40__24328.1608073129.jpg?c=1",
                GameId = 2
            },
            new ItemModel
            {
                Id = 31,
                Name = "Spider-Man",
                Image = "https://cdn11.bigcommerce.com/s-36f0xn7qz3/images/stencil/1060x1060/products/1136/1672/2481_Spider-Man_2017_40__97689.1608073067.jpg?c=1",
                GameId = 2
            },
            //GameId 5 DC: Superhjältar (Lätt) 4 kort
            new ItemModel
            {
                Id = 32,
                Name = "Batman",
                Image = "https://m.media-amazon.com/images/S/pv-target-images/9fd172a452587004a54251df846efdb16b3f2e808718c9dca35fe7ff68f508ac._SX1080_FMjpg_.jpg",
                GameId = 5
            },
            new ItemModel
            {
                Id = 33,
                Name = "Superman",
                Image = "https://cdn.flickeringmyth.com/wp-content/uploads/2021/09/superman-blu-ray-1629903679988.jpg",
                GameId = 5
            },
            new ItemModel
            {
                Id = 34,
                Name = "Wonder Woman",
                Image = "https://experiencethewonder.com/wp-content/uploads/2004/06/2004-WBCP-Justice-League-Unlimited-Animated-Style-Guide-Wonder-Woman-010.jpg",
                GameId = 5
            },
            new ItemModel
            {
                Id = 35,
                Name = "The Flash",
                Image = "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/1500x1500/products/87964/89908/The-Flash-DC-Comics-Lifesize-Cardboard-Cutout-available-now-at-starstills__31957.1474976928.jpg?c=2",
                GameId = 5
            }
            );


            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Frukt",
                    Image = "https://i.dietdoctor.com/se/wp-content/2019/10/Fruits-and-vegetables-guide.jpg?auto=compress%2Cformat&w=1200&h=800&fit=crop"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Djur",
                    Image = "https://img.pixers.pics/pho_wat(s3:700/FO/57/06/50/45/700_FO57065045_3947f9ea6db6ffee13e8d6526c4b092f.jpg,700,700,cms:2018/10/5bd1b6b8d04b8_220x50-watermark.png,over,480,650,jpg)/posters-vilda-djur-pa-cartoon-jungle-jungle-vilda-djur.jpg.jpg"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Bilar",
                    Image = "https://sohu-shop.se/images/wallstickers/wallstickers-med-catoon-biler.webp"
                },
                new CategoryModel()
                {
                    Id = 4,
                    Name = "Superhjältar",
                    Image = "https://t3.ftcdn.net/jpg/06/11/65/14/360_F_611651420_EgCnaCL6KDm3ukuMNmecVkaCHcfmbO6u.jpg"
                }
            );

            modelBuilder.Entity<DifficultyLevelModel>().HasData(
           new DifficultyLevelModel
           {
               Id = 1,
               Name = "Lätt",
               Level = 1,        // Easy 
               NrOfCards = 4
           },
           new DifficultyLevelModel
           {
               Id = 2,
               Name = "Medium",
               Level = 2,        // Medium
               NrOfCards = 8
           },
           new DifficultyLevelModel
           {
               Id = 3,
               Name = "Svår",
               Level = 3,        // Hard 
               NrOfCards = 15
           }
       );


            modelBuilder.Entity<GameModel>().HasData(
                new GameModel()
                {
                    Id = 1,
                    Name = "Goda frukter",
                    CategoryId = 1, // Frukt
                    DifficultyLevelId = 1, // Easy
                    GameType = "public",
                    CreatedBy = null,
                },
                new GameModel()
                {
                    Id = 2,
                    Name = "Marvel",
                    CategoryId = 4, // Superhjältar
                    DifficultyLevelId = 1, //Lätt
                    GameType = "public",
                    CreatedBy = null,
                },
                new GameModel()
                {
                    Id = 3,
                    Name = "Djur på bonnagården",
                    CategoryId = 2, // Djur
                    DifficultyLevelId = 2, //Medium
                    GameType = "public",
                    CreatedBy = null,
                },
                new GameModel()
                {
                    Id = 4,
                    Name = "Bilar man hade velat ha",
                    CategoryId = 3, // Bilar
                    DifficultyLevelId = 3, //Hard
                    GameType = "public",
                    CreatedBy = null,
                },
                new GameModel()
                {
                    Id = 5,
                    Name = "DC",
                    CategoryId = 4, // Superhjältar
                    DifficultyLevelId = 1, //Lätt
                    GameType = "public",
                    CreatedBy = null,
                }
            );

            modelBuilder.Entity<AchievementModel>().HasData(

                new AchievementModel()
                {
                    Id = 1,
                    Name = "Första steget!",
                    Description = "Klara ditt första spel",
                    ImageUrl = "Achievement1Game.jpg"
                },
                new AchievementModel()
                {
                    Id = 2,
                    Name = "Lärling",
                    Description = "Klara totalt 5 spel",
                    ImageUrl = "Achievement5Game.jpg"
                },
                new AchievementModel()
                {
                    Id = 3,
                    Name = "Magiker",
                    Description = "Klara total 20 spel",
                    ImageUrl = "Achievement20Game.jpg"
                },
                new AchievementModel()
                {
                    Id = 4,
                    Name = "Magi Mästare",
                    Description = "Klara total 100 spel",
                    ImageUrl = "Achievement100Game.jpg"
                },
                new AchievementModel()
                {
                    Id = 5,
                    Name = "Tidens lärling",
                    Description = "Klara ett spel under 5 minuter",
                    ImageUrl = "Achievement3minGame.jpg"
                },
                new AchievementModel()
                {
                    Id = 6,
                    Name = "Tidens Väktare",
                    Description = "Klara ett spel under 1 minut",
                    ImageUrl = "Achievement60secGame.jpg"
                },
                new AchievementModel()
                {
                    Id = 7,
                    Name = "Tidens Härskare",
                    Description = "Klara ett spel under 30 sekunder",
                    ImageUrl = "Achievement30secGame.jpg"
                },
                new AchievementModel()
                {
                    Id = 8,
                    Name = "Lärlingens Utmaning",
                    Description = "Klara ett spel med \"Lätt\" svårighetsgrad",
                    ImageUrl = "AchievementEasyGame.jpg"
                },
                new AchievementModel()
                {
                    Id = 9,
                    Name = "Trollkarlens Utmaning",
                    Description = "Klara ett spel med \"Medium\" svårighetsgrad",
                    ImageUrl = "AchievementMediumGame.jpg"
                },
                new AchievementModel()
                {
                    Id = 10,
                    Name = "Mästarens Utmaning",
                    Description = "Klara ett spel med \"Svår\" svårighetsgrad",
                    ImageUrl = "AchievementHardGame.jpg"
                }
            );
        }
    }
}

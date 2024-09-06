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
            /// AVKOMMENTERAT - AVKOMMENTERA SENARE VID ANVÄNDNING

            modelBuilder.Entity<ItemModel>().HasData(
            // Category Id : 1 - Mat
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
                Name = "Pasta",
                Image = "https://img.freepik.com/free-vector/spaghetti-pasta-with-bolognese-sauce_1308-115408.jpg?t=st=1725441659~exp=1725445259~hmac=cae2d1c081992be7f9b2697d6df20e9ffeb560de7546c7f8be2f602197921472&w=1380",
                GameId = 1
            },
            new ItemModel
            {
                Id = 3,
                Name = "Ananas",
                Image = "https://img.freepik.com/premium-vector/drawing-pineapple-with-green-top-yellow-top_1166763-24137.jpg?w=740",
                GameId = 1
            },
            new ItemModel
            {
                Id = 4,
                Name = "Pumpa",
                Image = "https://img.freepik.com/free-vector/fresh-pumpkin-white-b_1308-39708.jpg?t=st=1725442167~exp=1725445767~hmac=906c103466192496ecf2b6a977843c6c7588c65e5eb49bb89ee2da4a571bbf55&w=826",
                GameId = 1
            },
            new ItemModel
            {
                Id = 5,
                Name = "Jordgubbar",
                Image = "https://img.freepik.com/premium-vector/strawberry-clipart-vector-illustration-white-background_1280610-709.jpg?w=740",
                GameId = 1
            },
            new ItemModel
            {
                Id = 6,
                Name = "Fisk",
                Image = "https://img.freepik.com/premium-vector/cartoon-illustration-smiling-orange-white-clownfish_1216680-928.jpg?w=740",
                GameId = 1
            },
            // GameId 3: Djur
            new ItemModel
            {
                Id = 12,
                Name = "Fågel",
                Image = "https://img.freepik.com/free-vector/hand-drawn-flat-design-robin-collection_23-2149145170.jpg?t=st=1725442349~exp=1725445949~hmac=e0c69eb898156b90b344b8315ad7f4c468d28130b0d358eb7ba220eafc748e98&w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 13,
                Name = "Katt",
                Image = "https://img.freepik.com/premium-vector/cute-cat-collection-isolated-white-background_703032-4100.jpg?w=1380",
                GameId = 3
            },
            new ItemModel
            {
                Id = 14,
                Name = "Ko",
                Image = "https://img.freepik.com/premium-vector/cartoon-illustration-brown-white-cow_1216680-373.jpg?w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 15,
                Name = "Lejon",
                Image = "https://img.freepik.com/premium-vector/cute-lion-cartoon-white-background_29190-8567.jpg?w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 16,
                Name = "Apa",
                Image = "https://img.freepik.com/free-vector/monkey-cartoon-character-sticker_1308-76562.jpg?t=st=1725442733~exp=1725446333~hmac=261a58dc78d31af291802ee3e0912fd5f2f294d1d32da3a27fb91b75c6f30dfe&w=740",
                GameId = 3
            },
            new ItemModel
            {
                Id = 17,
                Name = "Varg",
                Image = "https://img.freepik.com/premium-vector/cartoon-dog-with-cartoon-face-word-wolf-it_1025542-56600.jpg?w=740",
                GameId = 3
            },
            // GameId 4: Bilar
            new ItemModel
            {
                Id = 18,
                Name = "sport bil",
                Image = "https://img.freepik.com/premium-vector/red-car-with-license-plate-number-3_1128391-17709.jpg?w=740",
                GameId = 4
            },
            new ItemModel
            {
                Id = 19,
                Name = "cabriolet bilen",
                Image = "https://img.freepik.com/free-vector/boy-driving-vintage-car-cartoon-design_1308-107242.jpg?t=st=1725453109~exp=1725456709~hmac=81d598da00b7fdb14f45c280734502f48e4d747188fd295ce35c102627bb0ad4&w=1800",
                GameId = 4
            },
            new ItemModel
            {
                Id = 20,
                Name = "Racer bilen",
                Image = "https://img.freepik.com/premium-vector/indy-car-speeding-f1-racing-f1-sports-car-illustration-vector_280080-22.jpg?w=1380,",
                GameId = 4
            },
            new ItemModel
            {
                Id = 21,
                Name = "Stadsjeepen",
                Image = "https://img.freepik.com/premium-vector/red-car-with-surfboard-top-it_1013341-387239.jpg?w=740",
                GameId = 4
            },
            new ItemModel
            {
                Id = 22,
                Name = "Sedan bilen",
                Image = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-background_1308-75583.jpg?t=st=1725452945~exp=1725456545~hmac=961c6db37d955480177b2eb6d6c6b7571efb30f5ff94d5fdd41dcc65c2c28521&w=1380",
                GameId = 4
            },
            new ItemModel
            {
                Id = 23,
                Name = "Veteran bilen",
                Image = "https://img.freepik.com/free-vector/classic-green-vintage-car-illustration_1308-164648.jpg?t=st=1725452987~exp=1725456587~hmac=dc808c875da97d90cb4641fdebe8f6718e4ff0dab6cb8aab516ef3495ffdb0f8&w=1380",
                GameId = 4
            });


            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Frukt",
                    Image = "images/Veteran_car.jpg"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Djur",
                    Image = "images/Veteran_car.jpg"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Bilar",
                    Image = "images/Veteran_car.jpg"
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
                }
            );

            modelBuilder.Entity<AchievementModel>().HasData(

                new AchievementModel()
                {
                    Id = 1,
                    Name = "Klarat första spelet!",
                    Description = "Mycket bra jobbat, du är på god väg!"
                },
                new AchievementModel()
                {
                    Id = 2,
                    Name = "Du har klarat andra spelet!",
                    Description = "Du är duktig, kämpa på!"
                },
                new AchievementModel()
                {
                    Id = 3,
                    Name = "Du klarade den första \"lätt\" nivån!",
                    Description = "Du klarade precis den lättaste nivån, kämpa på och försök klara nästa nivå!"
                },
                new AchievementModel()
                {
                    Id = 4,
                    Name = "Första vinsten!",
                    Description = "Din första vinst! Fortsätt att vinna och nå toppen!"
                },
                new AchievementModel()
                {
                    Id = 5,
                    Name = "Mästarens start!",
                    Description = "Du har tagit de första stegen mot att bli en mästare. Fortsätt så!"
                },
                new AchievementModel()
                {
                    Id = 6,
                    Name = "Du klarade den \"medel\" nivån!",
                    Description = "Bra jobbat! Nu har du klarat medelnivån, sikta på nästa!"
                },
                new AchievementModel()
                {
                    Id = 7,
                    Name = "Första perfekta poäng!",
                    Description = "Du fick perfekt poäng! Imponerande arbete!"
                },
                new AchievementModel()
                {
                    Id = 8,
                    Name = "Fler än 10 spel klara!",
                    Description = "Du har klarat fler än 10 spel! En riktig veteran!"
                },
                new AchievementModel()
                {
                    Id = 9,
                    Name = "Snabbaste tiden!",
                    Description = "Du har satt rekord för snabbaste tiden! Otroligt snabb!"
                },
                new AchievementModel()
                {
                    Id = 10,
                    Name = "Avklarat hela spelet!",
                    Description = "Fantastiskt! Du har klarat hela spelet! En prestation att vara stolt över!"
                }
                );

            // hehe
        }
    }
}

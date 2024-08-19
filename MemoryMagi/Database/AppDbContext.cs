using MemoryMagi.Models;
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

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<UserItem> UserItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /// AVKOMMENTERAT - AVKOMMENTERA SENARE VID ANVÄNDNING

            modelBuilder.Entity<Item>().HasData(
           // Category Id : 1 - Mat
           new Item
           {
               Id = 1,
               Name = "Äpple",
               Image = "images/Apples.jpg",
               CategoryId = 1
           },
           new Item
           {
               Id = 2,
               Name = "Pasta",
               Image = "images/Pasta.jpg",
               CategoryId = 1
           },
             new Item
             {
                 Id = 3,
                 Name = "Ananas",
                 Image = "images/Pineapple.jpg",
                 CategoryId = 1
             },
               new Item
               {
                   Id = 4,
                   Name = "Pumpa",
                   Image = "images/Pumpkins.jpg",
                   CategoryId = 1
               },
                 new Item
                 {
                     Id = 5,
                     Name = "Jordgubbar",
                     Image = "images/Starwberries.jpg",
                     CategoryId = 1
                 },
                   new Item
                   {
                       Id = 6,
                       Name = "Fisk",
                       Image = "images/Fish.jpg",
                       CategoryId = 1
                   },
                     // CategoryID 2 : Alkohol
                     new Item
                     {
                         Id = 7,
                         Name = "Öl",
                         Image = "images/Beer.jpg",
                         CategoryId = 2
                     },
                     new Item
                     {
                         Id = 8,
                         Name = "Cocktail",
                         Image = "images/Cocktail.jpg",
                         CategoryId = 2
                     },
                     new Item
                     {
                         Id = 9,
                         Name = "Crafted öl",
                         Image = "images/Crafted_beer.jpg",
                         CategoryId = 2
                     },
                     new Item
                     {
                         Id = 10,
                         Name = "Rött vin",
                         Image = "images/Red_Wine.jpg",
                         CategoryId = 2
                     },
                     new Item
                     {
                         Id = 11,
                         Name = "Vin",
                         Image = "images/Wine.jpg",
                         CategoryId = 2
                     },
                     // Cateogiry id 3: djur
                     new Item
                     {
                         Id = 12,
                         Name = "Fågel",
                         Image = "images/Bird.jpg",
                         CategoryId = 3
                     },
                     new Item
                     {
                         Id = 13,
                         Name = "Katt",
                         Image = "images/Cat.jpg",
                         CategoryId = 3
                     },
                     new Item
                     {
                         Id = 14,
                         Name = "Ko",
                         Image = "images/Cows.jpg",
                         CategoryId = 3
                     },
                     new Item
                     {
                         Id = 15,
                         Name = "Lejon",
                         Image = "images/Lion.jpg",
                         CategoryId = 3
                     },
                     new Item
                     {
                         Id = 16,
                         Name = "Apa",
                         Image = "images/Monkeys.jpg",
                         CategoryId = 3
                     },
                     new Item
                     {
                         Id = 17,
                         Name = "Varg",
                         Image = "images/Wolf.jpg",
                         CategoryId = 3
                     },
                     // Cateogiry id 4: bilar
                     new Item
                     {
                         Id = 18,
                         Name = "Cool bil",
                         Image = "images/Exoticc_car.jpg",
                         CategoryId = 4
                     },
                     new Item
                     {
                         Id = 19,
                         Name = "Pasta bilen",
                         Image = "images/Pastawagon_car.jpg",
                         CategoryId = 4
                     },
                     new Item
                     {
                         Id = 20,
                         Name = "Racer bilen",
                         Image = "images/Racecar_car.jpg",
                         CategoryId = 4
                     },
                     new Item
                     {
                         Id = 21,
                         Name = "Stadsjeepen",
                         Image = "images/SUV_car.jpg",
                         CategoryId = 4
                     },
                     new Item
                     {
                         Id = 22,
                         Name = "Ban bilen",
                         Image = "images/Trackcar_car.jpg",
                         CategoryId = 4
                     },
                     new Item
                     {
                         Id = 23,
                         Name = "Veteran bilen",
                         Image = "images/Veteran_car.jpg",
                         CategoryId = 4
                     }
                     );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Frukt"
                },
                 new Category()
                 {
                     Id = 2,
                     Name = "Alkohol"
                 },
                  new Category()
                  {
                      Id = 3,
                      Name = "Djur"
                  },
                   new Category()
                   {
                       Id = 4,
                       Name = "Bilar"
                   }
                );


            // hehe
        }
    }
}

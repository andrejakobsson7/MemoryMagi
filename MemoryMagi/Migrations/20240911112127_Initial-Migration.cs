using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageurl = table.Column<string>(name: "image-url", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DifficultyLevels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    nr_of_cards = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    achievement_id = table.Column<int>(type: "int", nullable: false),
                    achievement_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements", x => new { x.user_id, x.achievement_id });
                    table.ForeignKey(
                        name: "FK_UserAchievements_Achievements_achievement_id",
                        column: x => x.achievement_id,
                        principalTable: "Achievements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievements_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    difficulty_level_id = table.Column<int>(type: "int", nullable: false),
                    game_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.id);
                    table.ForeignKey(
                        name: "FK_Games_AspNetUsers_created_by",
                        column: x => x.created_by,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Categories_category_id",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_DifficultyLevels_difficulty_level_id",
                        column: x => x.difficulty_level_id,
                        principalTable: "DifficultyLevels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllowedUsers",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    game_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedUsers", x => new { x.user_id, x.game_id });
                    table.ForeignKey(
                        name: "FK_AllowedUsers_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllowedUsers_Games_game_id",
                        column: x => x.game_id,
                        principalTable: "Games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    game_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_Games_game_id",
                        column: x => x.game_id,
                        principalTable: "Games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    game_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    time = table.Column<TimeSpan>(type: "time", nullable: false),
                    date_played = table.Column<DateTime>(type: "datetime2", nullable: false),
                    passed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.id);
                    table.ForeignKey(
                        name: "FK_Results_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Games_game_id",
                        column: x => x.game_id,
                        principalTable: "Games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "id", "description", "image-url", "name" },
                values: new object[,]
                {
                    { 1, "Klara ditt första spel", "Achievement1Game.jpg", "Första steget!" },
                    { 2, "Klara totalt 5 spel", "Achievement5Game.jpg", "Lärling" },
                    { 3, "Klara total 20 spel", "Achievement20Game.jpg", "Magiker" },
                    { 4, "Klara total 100 spel", "Achievement100Game.jpg", "Magi Mästare" },
                    { 5, "Klara ett spel under 5 minuter", "Achievement3minGame.jpg", "Tidens lärling" },
                    { 6, "Klara ett spel under 1 minut", "Achievement60secGame.jpg", "Tidens Väktare" },
                    { 7, "Klara ett spel under 30 sekunder", "Achievement30secGame.jpg", "Tidens Härskare" },
                    { 8, "Klara ett spel med \"Lätt\" svårighetsgrad", "AchievementEasyGame.jpg", "Lärlingens Utmaning" },
                    { 9, "Klara ett spel med \"Medium\" svårighetsgrad", "AchievementMediumGame.jpg", "Trollkarlens Utmaning" },
                    { 10, "Klara ett spel med \"Svår\" svårighetsgrad", "AchievementHardGame.jpg", "Mästarens Utmaning" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "image_url", "name" },
                values: new object[,]
                {
                    { 1, "images/Veteran_car.jpg", "Frukt" },
                    { 2, "images/Veteran_car.jpg", "Djur" },
                    { 3, "images/Veteran_car.jpg", "Bilar" }
                });

            migrationBuilder.InsertData(
                table: "DifficultyLevels",
                columns: new[] { "id", "level", "name", "nr_of_cards" },
                values: new object[,]
                {
                    { 1, 1, "Lätt", 4 },
                    { 2, 2, "Medium", 8 },
                    { 3, 3, "Svår", 15 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "id", "category_id", "created_by", "difficulty_level_id", "game_type", "name" },
                values: new object[,]
                {
                    { 1, 1, null, 1, "public", "Goda frukter" },
                    { 3, 2, null, 2, "public", "Djur på bonnagården" },
                    { 4, 3, null, 3, "public", "Bilar man hade velat ha" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "id", "game_id", "image", "name" },
                values: new object[,]
                {
                    { 1, 1, "https://img.freepik.com/free-vector/sticker-design-with-apple-isolated_1308-66383.jpg?t=st=1725441600~exp=1725445200~hmac=2b353ba4b82a3ad64efda6bf389b2541f080abace5c4b2650920cfd765f9e236&w=740", "Äpple" },
                    { 2, 1, "https://img.freepik.com/free-vector/spaghetti-pasta-with-bolognese-sauce_1308-115408.jpg?t=st=1725441659~exp=1725445259~hmac=cae2d1c081992be7f9b2697d6df20e9ffeb560de7546c7f8be2f602197921472&w=1380", "Pasta" },
                    { 3, 1, "https://img.freepik.com/premium-vector/drawing-pineapple-with-green-top-yellow-top_1166763-24137.jpg?w=740", "Ananas" },
                    { 4, 1, "https://img.freepik.com/free-vector/fresh-pumpkin-white-b_1308-39708.jpg?t=st=1725442167~exp=1725445767~hmac=906c103466192496ecf2b6a977843c6c7588c65e5eb49bb89ee2da4a571bbf55&w=826", "Pumpa" },
                    { 5, 1, "https://img.freepik.com/premium-vector/strawberry-clipart-vector-illustration-white-background_1280610-709.jpg?w=740", "Jordgubbar" },
                    { 6, 1, "https://img.freepik.com/premium-vector/cartoon-illustration-smiling-orange-white-clownfish_1216680-928.jpg?w=740", "Fisk" },
                    { 12, 3, "https://img.freepik.com/free-vector/hand-drawn-flat-design-robin-collection_23-2149145170.jpg?t=st=1725442349~exp=1725445949~hmac=e0c69eb898156b90b344b8315ad7f4c468d28130b0d358eb7ba220eafc748e98&w=740", "Fågel" },
                    { 13, 3, "https://img.freepik.com/premium-vector/cute-cat-collection-isolated-white-background_703032-4100.jpg?w=1380", "Katt" },
                    { 14, 3, "https://img.freepik.com/premium-vector/cartoon-illustration-brown-white-cow_1216680-373.jpg?w=740", "Ko" },
                    { 15, 3, "https://img.freepik.com/premium-vector/cute-lion-cartoon-white-background_29190-8567.jpg?w=740", "Lejon" },
                    { 16, 3, "https://img.freepik.com/free-vector/monkey-cartoon-character-sticker_1308-76562.jpg?t=st=1725442733~exp=1725446333~hmac=261a58dc78d31af291802ee3e0912fd5f2f294d1d32da3a27fb91b75c6f30dfe&w=740", "Apa" },
                    { 17, 3, "https://img.freepik.com/premium-vector/cartoon-dog-with-cartoon-face-word-wolf-it_1025542-56600.jpg?w=740", "Varg" },
                    { 18, 4, "https://img.freepik.com/premium-vector/red-car-with-license-plate-number-3_1128391-17709.jpg?w=740", "sport bil" },
                    { 19, 4, "https://img.freepik.com/free-vector/boy-driving-vintage-car-cartoon-design_1308-107242.jpg?t=st=1725453109~exp=1725456709~hmac=81d598da00b7fdb14f45c280734502f48e4d747188fd295ce35c102627bb0ad4&w=1800", "cabriolet bilen" },
                    { 20, 4, "https://img.freepik.com/premium-vector/indy-car-speeding-f1-racing-f1-sports-car-illustration-vector_280080-22.jpg?w=1380,", "Racer bilen" },
                    { 21, 4, "https://img.freepik.com/premium-vector/red-car-with-surfboard-top-it_1013341-387239.jpg?w=740", "Stadsjeepen" },
                    { 22, 4, "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-background_1308-75583.jpg?t=st=1725452945~exp=1725456545~hmac=961c6db37d955480177b2eb6d6c6b7571efb30f5ff94d5fdd41dcc65c2c28521&w=1380", "Sedan bilen" },
                    { 23, 4, "https://img.freepik.com/free-vector/classic-green-vintage-car-illustration_1308-164648.jpg?t=st=1725452987~exp=1725456587~hmac=dc808c875da97d90cb4641fdebe8f6718e4ff0dab6cb8aab516ef3495ffdb0f8&w=1380", "Veteran bilen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllowedUsers_game_id",
                table: "AllowedUsers",
                column: "game_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Games_category_id",
                table: "Games",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_created_by",
                table: "Games",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Games_difficulty_level_id",
                table: "Games",
                column: "difficulty_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_game_id",
                table: "Items",
                column: "game_id");

            migrationBuilder.CreateIndex(
                name: "IX_Results_game_id",
                table: "Results",
                column: "game_id");

            migrationBuilder.CreateIndex(
                name: "IX_Results_user_id",
                table: "Results",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_achievement_id",
                table: "UserAchievements",
                column: "achievement_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowedUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "UserAchievements");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "DifficultyLevels");
        }
    }
}

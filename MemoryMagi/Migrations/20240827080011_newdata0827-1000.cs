using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class newdata08271000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllowedUsers_2_AspNetUsers_user_id",
                table: "AllowedUsers_2");

            migrationBuilder.DropForeignKey(
                name: "FK_AllowedUsers_2_Games_2_game_id",
                table: "AllowedUsers_2");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_user_id",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_2_AspNetUsers_created_by",
                table: "Games_2");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_2_Categories_2_category_id",
                table: "Games_2");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_2_DifficultyLevels_2_difficulty_level_id",
                table: "Games_2");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_2_GameTypes_2_game_type_id",
                table: "Games_2");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categories_category_id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_2_AspNetUsers_user_id",
                table: "Results_2");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_2_Games_2_game_id",
                table: "Results_2");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_2_Achievements_2_achievement_id",
                table: "UserAchievements_2");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_2_AspNetUsers_user_id",
                table: "UserAchievements_2");

            migrationBuilder.DropTable(
                name: "Categories_2");

            migrationBuilder.DropTable(
                name: "GameTypes_2");

            migrationBuilder.DropTable(
                name: "Items_2");

            migrationBuilder.DropTable(
                name: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_Categories_user_id",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAchievements_2",
                table: "UserAchievements_2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Results_2",
                table: "Results_2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games_2",
                table: "Games_2");

            migrationBuilder.DropIndex(
                name: "IX_Games_2_game_type_id",
                table: "Games_2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DifficultyLevels_2",
                table: "DifficultyLevels_2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AllowedUsers_2",
                table: "AllowedUsers_2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Achievements_2",
                table: "Achievements_2");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "game_type_id",
                table: "Games_2");

            migrationBuilder.RenameTable(
                name: "UserAchievements_2",
                newName: "UserAchievements");

            migrationBuilder.RenameTable(
                name: "Results_2",
                newName: "Results");

            migrationBuilder.RenameTable(
                name: "Games_2",
                newName: "Games");

            migrationBuilder.RenameTable(
                name: "DifficultyLevels_2",
                newName: "DifficultyLevels");

            migrationBuilder.RenameTable(
                name: "AllowedUsers_2",
                newName: "AllowedUsers");

            migrationBuilder.RenameTable(
                name: "Achievements_2",
                newName: "Achievements");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Items",
                newName: "game_id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_category_id",
                table: "Items",
                newName: "IX_Items_game_id");

            migrationBuilder.RenameIndex(
                name: "IX_UserAchievements_2_achievement_id",
                table: "UserAchievements",
                newName: "IX_UserAchievements_achievement_id");

            migrationBuilder.RenameIndex(
                name: "IX_Results_2_game_id",
                table: "Results",
                newName: "IX_Results_game_id");

            migrationBuilder.RenameIndex(
                name: "IX_Games_2_difficulty_level_id",
                table: "Games",
                newName: "IX_Games_difficulty_level_id");

            migrationBuilder.RenameIndex(
                name: "IX_Games_2_created_by",
                table: "Games",
                newName: "IX_Games_created_by");

            migrationBuilder.RenameIndex(
                name: "IX_Games_2_category_id",
                table: "Games",
                newName: "IX_Games_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_AllowedUsers_2_game_id",
                table: "AllowedUsers",
                newName: "IX_AllowedUsers_game_id");

            migrationBuilder.AddColumn<string>(
                name: "game_type",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements",
                columns: new[] { "user_id", "achievement_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                columns: new[] { "user_id", "game_id", "date_played" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DifficultyLevels",
                table: "DifficultyLevels",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllowedUsers",
                table: "AllowedUsers",
                columns: new[] { "user_id", "game_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Achievements",
                table: "Achievements",
                column: "id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "image_url", "name" },
                values: new object[,]
                {
                    { 1, "images/Veteran_car.jpg", "Frukt" },
                    { 2, "images/Veteran_car.jpg", "Alkohol" },
                    { 3, "images/Veteran_car.jpg", "Djur" },
                    { 4, "images/Veteran_car.jpg", "Bilar" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 1,
                column: "game_type",
                value: "public");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 2,
                column: "game_type",
                value: "public");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 3,
                column: "game_type",
                value: "public");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "id",
                keyValue: 4,
                column: "game_type",
                value: "public");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "id", "game_id", "image", "name" },
                values: new object[,]
                {
                    { 1, 1, "images/Apples.jpg", "Äpple" },
                    { 2, 1, "images/Pasta.jpg", "Pasta" },
                    { 3, 1, "images/Pineapple.jpg", "Ananas" },
                    { 4, 1, "images/Pumpkins.jpg", "Pumpa" },
                    { 5, 1, "images/Strawberries.jpg", "Jordgubbar" },
                    { 6, 1, "images/Fish.jpg", "Fisk" },
                    { 7, 2, "images/Beer.jpg", "Öl" },
                    { 8, 2, "images/Cocktail.jpg", "Cocktail" },
                    { 9, 2, "images/Crafted_beer.jpg", "Crafted öl" },
                    { 10, 2, "images/Red_Wine.jpg", "Rött vin" },
                    { 11, 2, "images/Wine.jpg", "Vin" },
                    { 12, 3, "images/Bird.jpg", "Fågel" },
                    { 13, 3, "images/Cat.jpg", "Katt" },
                    { 14, 3, "images/Cows.jpg", "Ko" },
                    { 15, 3, "images/Lion.jpg", "Lejon" },
                    { 16, 3, "images/Monkeys.jpg", "Apa" },
                    { 17, 3, "images/Wolf.jpg", "Varg" },
                    { 18, 4, "images/Exotic_car.jpg", "Cool bil" },
                    { 19, 4, "images/Pastawagon_car.jpg", "Pasta bilen" },
                    { 20, 4, "images/Racecar_car.jpg", "Racer bilen" },
                    { 21, 4, "images/SUV_car.jpg", "Stadsjeepen" },
                    { 22, 4, "images/Trackcar_car.jpg", "Ban bilen" },
                    { 23, 4, "images/Veteran_car.jpg", "Veteran bilen" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AllowedUsers_AspNetUsers_user_id",
                table: "AllowedUsers",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AllowedUsers_Games_game_id",
                table: "AllowedUsers",
                column: "game_id",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_created_by",
                table: "Games",
                column: "created_by",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_category_id",
                table: "Games",
                column: "category_id",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_DifficultyLevels_difficulty_level_id",
                table: "Games",
                column: "difficulty_level_id",
                principalTable: "DifficultyLevels",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Games_game_id",
                table: "Items",
                column: "game_id",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_AspNetUsers_user_id",
                table: "Results",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Games_game_id",
                table: "Results",
                column: "game_id",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_Achievements_achievement_id",
                table: "UserAchievements",
                column: "achievement_id",
                principalTable: "Achievements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_AspNetUsers_user_id",
                table: "UserAchievements",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllowedUsers_AspNetUsers_user_id",
                table: "AllowedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AllowedUsers_Games_game_id",
                table: "AllowedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_created_by",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_category_id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_DifficultyLevels_difficulty_level_id",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Games_game_id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_AspNetUsers_user_id",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Games_game_id",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_Achievements_achievement_id",
                table: "UserAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_AspNetUsers_user_id",
                table: "UserAchievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DifficultyLevels",
                table: "DifficultyLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AllowedUsers",
                table: "AllowedUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Achievements",
                table: "Achievements");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6);

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
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DropColumn(
                name: "game_type",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "UserAchievements",
                newName: "UserAchievements_2");

            migrationBuilder.RenameTable(
                name: "Results",
                newName: "Results_2");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Games_2");

            migrationBuilder.RenameTable(
                name: "DifficultyLevels",
                newName: "DifficultyLevels_2");

            migrationBuilder.RenameTable(
                name: "AllowedUsers",
                newName: "AllowedUsers_2");

            migrationBuilder.RenameTable(
                name: "Achievements",
                newName: "Achievements_2");

            migrationBuilder.RenameColumn(
                name: "game_id",
                table: "Items",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_game_id",
                table: "Items",
                newName: "IX_Items_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_UserAchievements_achievement_id",
                table: "UserAchievements_2",
                newName: "IX_UserAchievements_2_achievement_id");

            migrationBuilder.RenameIndex(
                name: "IX_Results_game_id",
                table: "Results_2",
                newName: "IX_Results_2_game_id");

            migrationBuilder.RenameIndex(
                name: "IX_Games_difficulty_level_id",
                table: "Games_2",
                newName: "IX_Games_2_difficulty_level_id");

            migrationBuilder.RenameIndex(
                name: "IX_Games_created_by",
                table: "Games_2",
                newName: "IX_Games_2_created_by");

            migrationBuilder.RenameIndex(
                name: "IX_Games_category_id",
                table: "Games_2",
                newName: "IX_Games_2_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_AllowedUsers_game_id",
                table: "AllowedUsers_2",
                newName: "IX_AllowedUsers_2_game_id");

            migrationBuilder.AddColumn<string>(
                name: "user_id",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "game_type_id",
                table: "Games_2",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAchievements_2",
                table: "UserAchievements_2",
                columns: new[] { "user_id", "achievement_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results_2",
                table: "Results_2",
                columns: new[] { "user_id", "game_id", "date_played" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games_2",
                table: "Games_2",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DifficultyLevels_2",
                table: "DifficultyLevels_2",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllowedUsers_2",
                table: "AllowedUsers_2",
                columns: new[] { "user_id", "game_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Achievements_2",
                table: "Achievements_2",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Categories_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories_2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GameTypes_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    game_type = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes_2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Items_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    game_id = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items_2", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_2_Games_2_game_id",
                        column: x => x.game_id,
                        principalTable: "Games_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserItems",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    is_complete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItems", x => new { x.user_id, x.item_id });
                    table.ForeignKey(
                        name: "FK_UserItems_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserItems_Items_item_id",
                        column: x => x.item_id,
                        principalTable: "Items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories_2",
                columns: new[] { "id", "image_url", "name" },
                values: new object[,]
                {
                    { 1, "images/Veteran_car.jpg", "Frukt" },
                    { 2, "images/Veteran_car.jpg", "Alkohol" },
                    { 3, "images/Veteran_car.jpg", "Djur" },
                    { 4, "images/Veteran_car.jpg", "Bilar" }
                });

            migrationBuilder.InsertData(
                table: "GameTypes_2",
                columns: new[] { "id", "game_type", "name" },
                values: new object[,]
                {
                    { 1, 1, "Public" },
                    { 2, 2, "Private" }
                });

            migrationBuilder.UpdateData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 1,
                column: "game_type_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 2,
                column: "game_type_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 3,
                column: "game_type_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Games_2",
                keyColumn: "id",
                keyValue: 4,
                column: "game_type_id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Items_2",
                columns: new[] { "id", "game_id", "image", "name" },
                values: new object[,]
                {
                    { 1, 1, "images/Apples.jpg", "Äpple" },
                    { 2, 1, "images/Pasta.jpg", "Pasta" },
                    { 3, 1, "images/Pineapple.jpg", "Ananas" },
                    { 4, 1, "images/Pumpkins.jpg", "Pumpa" },
                    { 5, 1, "images/Strawberries.jpg", "Jordgubbar" },
                    { 6, 1, "images/Fish.jpg", "Fisk" },
                    { 7, 2, "images/Beer.jpg", "Öl" },
                    { 8, 2, "images/Cocktail.jpg", "Cocktail" },
                    { 9, 2, "images/Crafted_beer.jpg", "Crafted öl" },
                    { 10, 2, "images/Red_Wine.jpg", "Rött vin" },
                    { 11, 2, "images/Wine.jpg", "Vin" },
                    { 12, 3, "images/Bird.jpg", "Fågel" },
                    { 13, 3, "images/Cat.jpg", "Katt" },
                    { 14, 3, "images/Cows.jpg", "Ko" },
                    { 15, 3, "images/Lion.jpg", "Lejon" },
                    { 16, 3, "images/Monkeys.jpg", "Apa" },
                    { 17, 3, "images/Wolf.jpg", "Varg" },
                    { 18, 4, "images/Exotic_car.jpg", "Cool bil" },
                    { 19, 4, "images/Pastawagon_car.jpg", "Pasta bilen" },
                    { 20, 4, "images/Racecar_car.jpg", "Racer bilen" },
                    { 21, 4, "images/SUV_car.jpg", "Stadsjeepen" },
                    { 22, 4, "images/Trackcar_car.jpg", "Ban bilen" },
                    { 23, 4, "images/Veteran_car.jpg", "Veteran bilen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_user_id",
                table: "Categories",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_2_game_type_id",
                table: "Games_2",
                column: "game_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_2_game_id",
                table: "Items_2",
                column: "game_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_item_id",
                table: "UserItems",
                column: "item_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AllowedUsers_2_AspNetUsers_user_id",
                table: "AllowedUsers_2",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AllowedUsers_2_Games_2_game_id",
                table: "AllowedUsers_2",
                column: "game_id",
                principalTable: "Games_2",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_user_id",
                table: "Categories",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_2_AspNetUsers_created_by",
                table: "Games_2",
                column: "created_by",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_2_Categories_2_category_id",
                table: "Games_2",
                column: "category_id",
                principalTable: "Categories_2",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_2_DifficultyLevels_2_difficulty_level_id",
                table: "Games_2",
                column: "difficulty_level_id",
                principalTable: "DifficultyLevels_2",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_2_GameTypes_2_game_type_id",
                table: "Games_2",
                column: "game_type_id",
                principalTable: "GameTypes_2",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categories_category_id",
                table: "Items",
                column: "category_id",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_2_AspNetUsers_user_id",
                table: "Results_2",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_2_Games_2_game_id",
                table: "Results_2",
                column: "game_id",
                principalTable: "Games_2",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_2_Achievements_2_achievement_id",
                table: "UserAchievements_2",
                column: "achievement_id",
                principalTable: "Achievements_2",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_2_AspNetUsers_user_id",
                table: "UserAchievements_2",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

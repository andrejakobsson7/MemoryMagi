using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoryMagi.Migrations
{
    /// <inheritdoc />
    public partial class upgradeDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements_2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories_2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DifficultyLevels_2",
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
                    table.PrimaryKey("PK_DifficultyLevels_2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GameTypes_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    game_type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes_2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements_2",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    achievement_id = table.Column<int>(type: "int", nullable: false),
                    achievement_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements_2", x => new { x.user_id, x.achievement_id });
                    table.ForeignKey(
                        name: "FK_UserAchievements_2_Achievements_2_achievement_id",
                        column: x => x.achievement_id,
                        principalTable: "Achievements_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievements_2_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    difficulty_level_id = table.Column<int>(type: "int", nullable: false),
                    game_type_id = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_2", x => x.id);
                    table.ForeignKey(
                        name: "FK_Games_2_AspNetUsers_created_by",
                        column: x => x.created_by,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_2_Categories_2_category_id",
                        column: x => x.category_id,
                        principalTable: "Categories_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_2_DifficultyLevels_2_difficulty_level_id",
                        column: x => x.difficulty_level_id,
                        principalTable: "DifficultyLevels_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_2_GameTypes_2_game_type_id",
                        column: x => x.game_type_id,
                        principalTable: "GameTypes_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllowedUsers_2",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    game_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedUsers_2", x => new { x.user_id, x.game_id });
                    table.ForeignKey(
                        name: "FK_AllowedUsers_2_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllowedUsers_2_Games_2_game_id",
                        column: x => x.game_id,
                        principalTable: "Games_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items_2",
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
                    table.PrimaryKey("PK_Items_2", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_2_Games_2_game_id",
                        column: x => x.game_id,
                        principalTable: "Games_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Results_2",
                columns: table => new
                {
                    game_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    time = table.Column<TimeSpan>(type: "time", nullable: false),
                    date_played = table.Column<DateOnly>(type: "date", nullable: false),
                    passed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results_2", x => new { x.user_id, x.game_id });
                    table.ForeignKey(
                        name: "FK_Results_2_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_2_Games_2_game_id",
                        column: x => x.game_id,
                        principalTable: "Games_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllowedUsers_2_game_id",
                table: "AllowedUsers_2",
                column: "game_id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_2_category_id",
                table: "Games_2",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_2_created_by",
                table: "Games_2",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Games_2_difficulty_level_id",
                table: "Games_2",
                column: "difficulty_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_2_game_type_id",
                table: "Games_2",
                column: "game_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_2_game_id",
                table: "Items_2",
                column: "game_id");

            migrationBuilder.CreateIndex(
                name: "IX_Results_2_game_id",
                table: "Results_2",
                column: "game_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_2_achievement_id",
                table: "UserAchievements_2",
                column: "achievement_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowedUsers_2");

            migrationBuilder.DropTable(
                name: "Items_2");

            migrationBuilder.DropTable(
                name: "Results_2");

            migrationBuilder.DropTable(
                name: "UserAchievements_2");

            migrationBuilder.DropTable(
                name: "Games_2");

            migrationBuilder.DropTable(
                name: "Achievements_2");

            migrationBuilder.DropTable(
                name: "Categories_2");

            migrationBuilder.DropTable(
                name: "DifficultyLevels_2");

            migrationBuilder.DropTable(
                name: "GameTypes_2");
        }
    }
}

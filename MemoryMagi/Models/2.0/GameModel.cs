using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class GameModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("difficulty_level_id")]
        public int DifficultyLevelId { get; set; }

        [Column("game_type")]
        public string? GameType { get; set; }

        [ForeignKey("User")]
        [Column("created_by")]
        public string? CreatedBy { get; set; }

        //Navigation properties
        public CategoryModel? Category { get; set; }
        public DifficultyLevelModel? DifficultyLevel { get; set; }
        public ApplicationUser? User { get; set; }

        [ValidateItemsLength]
        public List<ItemModel> Items { get; set; } = new();
        public List<ResultModel> Results { get; set; } = new();
        public List<AllowedUser> AllowedUsers { get; set; } = new();
    }
}

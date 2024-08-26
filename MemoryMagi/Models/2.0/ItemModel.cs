using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class ItemModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("image")]
        public string Image { get; set; } = null!;

        [Column("game_id")]
        public int GameId { get; set; }

        public GameModel? Game { get; set; }
    }
}

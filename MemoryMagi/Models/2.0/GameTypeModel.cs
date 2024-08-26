using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class GameTypeModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("game_type")]
        public int GameType { get; set; }

        //Navigation properties
        public List<GameModel>? Games { get; set; } = new();

    }
}

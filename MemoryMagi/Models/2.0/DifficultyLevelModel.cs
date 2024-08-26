using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class DifficultyLevelModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("level")]
        public int Level { get; set; }

        [Column("nr_of_cards")]
        public int NrOfCards { get; set; }

        //Navigation properties
        public List<GameModel>? Games { get; set; } = new();
    }
}

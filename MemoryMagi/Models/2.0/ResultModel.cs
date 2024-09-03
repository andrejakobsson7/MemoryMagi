using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class ResultModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("game_id")]
        public int GameId { get; set; }

        [Column("user_id")]
        public string UserId { get; set; } = null!;

        [Column("time")]
        public TimeSpan Time { get; set; }

        [Column("date_played")]
        public DateTime DatePlayed { get; set; }

        [Column("passed")]
        public bool Passed { get; set; }

        //Navigation property
        public GameModel? Game { get; set; }

        public ApplicationUser? User { get; set; }
    }
}

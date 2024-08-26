using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    [PrimaryKey("UserId", new string[] { "GameId", "DatePlayed" })]

    public class ResultModel
    {
        [ForeignKey("Game")]
        [Column("game_id")]
        public int GameId { get; set; }

        [ForeignKey("User")]
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

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    [PrimaryKey("UserId", new string[] { "GameId" })]

    public class AllowedUser
    {
        [ForeignKey("User")]
        [Column("user_id")]
        public string? UserId { get; set; }

        [ForeignKey("Game")]
        [Column("game_id")]
        public int GameId { get; set; }

        //Navigation properties
        public ApplicationUser? User { get; set; }
        public GameModel? Game { get; set; }
    }
}

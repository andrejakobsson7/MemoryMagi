using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models._2._0
{
    [PrimaryKey("UserId", new string[] { "AchievementId" })]

    public class UserAchievement
    {
        [ForeignKey("User")]
        [Column("user_id")]
        public string UserId { get; set; } = null!;

        [ForeignKey("Achievement")]
        [Column("achievement_id")]
        public int AchievementId { get; set; }

        [Column("achievement_date")]
        public DateOnly AchievementDate { get; set; }

        //Navigation properties
        public ApplicationUser? User { get; set; }

        public AchievementModel? Achievement { get; set; }
    }
}

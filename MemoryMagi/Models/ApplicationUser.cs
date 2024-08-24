using MemoryMagi.Models._2._0;
using Microsoft.AspNetCore.Identity;

namespace MemoryMagi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<UserItem>? UserItems { get; set; } = new();

        public List<UserAchievement>? UserAchievements { get; set; } = new();

        public List<AllowedUser>? AllowedUsers { get; set; } = new();
    }
}

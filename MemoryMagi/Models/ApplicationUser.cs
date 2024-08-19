using Microsoft.AspNetCore.Identity;

namespace MemoryMagi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<UserItem> UserItems { get; set; } = new();
    }
}

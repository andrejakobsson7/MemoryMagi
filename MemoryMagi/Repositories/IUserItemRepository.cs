using MemoryMagi.Database;
using MemoryMagi.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public interface IUserItemRepository
    {
        public AppDbContext _context { get; set; }

        public Task<List<UserItem>> AddUserItemsAsync(List<UserItem> userItems);

        public async Task<List<UserItem>> GetUserItemsByUserId(string userId)
        {
            return await _context.UserItems
                                 .Where(ui => ui.UserId == userId)
                                 .ToListAsync();
        }
    }
}

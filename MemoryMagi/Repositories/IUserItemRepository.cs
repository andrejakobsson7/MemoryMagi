using MemoryMagi.Database;
using MemoryMagi.Models;

namespace MemoryMagi.Repositories
{
    public interface IUserItemRepository
    {
        public AppDbContext _context { get; set; }

        public Task<List<UserItem>> AddUserItemsAsync(List<UserItem> userItems);
    }
}

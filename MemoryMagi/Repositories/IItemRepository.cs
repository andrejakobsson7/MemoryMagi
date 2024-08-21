using MemoryMagi.Database;
using MemoryMagi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MemoryMagi.Repositories
{
    public interface IItemRepository
    {
        public AppDbContext _context { get; set; }
        public Task<List<Item>> GetAllItemsAsync();
        public Task<Item> GetItemByIdAsync(int id);
        public Task<Item> AddItemAsync(Item newItem);
        public Task UpdateItemAsync(Item updatedItem);
    }
}

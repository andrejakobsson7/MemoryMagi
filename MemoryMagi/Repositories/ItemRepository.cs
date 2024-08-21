using MemoryMagi.Database;
using MemoryMagi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MemoryMagi.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public AppDbContext _context { get; set; }

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await _context.Items.FindAsync(id);
        }

        public async Task<Item> AddItemAsync(Item newItem)
        {
            await _context.Items.AddAsync(newItem);
            await _context.SaveChangesAsync();
            return newItem;
        }

        public async Task UpdateItemAsync(Item updatedItem)
        {
            _context.Entry(updatedItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

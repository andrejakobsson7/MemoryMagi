using MemoryMagi.Database;
using MemoryMagi.Models;
using Microsoft.EntityFrameworkCore;


namespace MemoryMagi.Repositories
{

    public class ItemRepository
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


    }
}

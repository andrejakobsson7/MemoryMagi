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

        public async Task<List<ItemModel>> GetAllitemsFromGameId(int gameId)
        {
            //  return await _context.Items.ToListAsync();

            return await _context.Items
                        .Where(item => item.GameId == gameId).ToListAsync();

        }

        public async Task<List<ItemModel>> GetAllItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }


    }
}
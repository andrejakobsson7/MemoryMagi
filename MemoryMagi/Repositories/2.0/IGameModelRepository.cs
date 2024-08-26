using MemoryMagi.Database;
using MemoryMagi.Models;

namespace MemoryMagi.Repositories._2._0
{
    public interface IGameModelRepository
    {
        public AppDbContext _context { get; set; }

        public Task<List<GameModel>> GetAllGamesWithIncludedDataAsync(string userId);
    }
}

using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Repositories._2._0;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public class GameModelRepository : IGameModelRepository
    {
        public AppDbContext _context { get; set; }

        public GameModelRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GameModel>> GetAllGamesWithIncludedDataAsync(string userId)
        {
            //Get games that the user has either created, are public or that the user has been invited to.
            //Then get the related data for these games and return it.
            //Only include results that belongs to the specific user.
            return await _context.Games_2
            .Where(g => g.CreatedBy == userId || g.GameType.GameType == 1 ||
            g.AllowedUsers.Any(u => u.UserId == userId)).
            Include(g => g.DifficultyLevel).
            Include(g => g.Category).
            Include(g => g.GameType).
            Include(g => g.Results.Where(g => g.UserId == userId))
            .ToListAsync();
        }
    }
}

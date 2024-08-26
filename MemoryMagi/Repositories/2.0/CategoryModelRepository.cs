using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Repositories._2._0;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public class CategoryModelRepository : ICategoryModelRepository
    {

        public AppDbContext _context { get; set; }

        public CategoryModelRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GameModel>> GetAllCategoriesAsync(string userId)
        {
            //        return await _context.Categories_2
            //.Include(c => c.Games.Where(g => g.CreatedBy == userId ||
            //                                 g.Results.Any(r => r.UserId == userId) ||
            //                                 g.AllowedUsers.Any(u => u.UserId == userId)))
            //    .ThenInclude(g => g.DifficultyLevel)
            //.Include(c => c.Games.Where(g => g.CreatedBy == userId ||
            //                                 g.Results.Any(r => r.UserId == userId) ||
            //                                 g.AllowedUsers.Any(u => u.UserId == userId)))
            //    .ThenInclude(g => g.GameType)
            //.Include(c => c.Games.Where(g => g.CreatedBy == userId ||
            //                                 g.Results.Any(r => r.UserId == userId) ||
            //                                 g.AllowedUsers.Any(u => u.UserId == userId)))
            //    .ThenInclude(g => g.Results)
            //.Include(c => c.Games.Where(g => g.CreatedBy == userId ||
            //                                 g.Results.Any(r => r.UserId == userId) ||
            //                                 g.AllowedUsers.Any(u => u.UserId == userId)))
            //    .ThenInclude(g => g.AllowedUsers)
            //.ToListAsync();

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

            //Get categories
            //        return await _context.Categories_2
            //.Where(c => c.Games.Any(g => filteredGames.Select(fg => fg.Id).Contains(g.Id)))
            //.Include(c => c.Games.Where(g => filteredGames.Select(fg => fg.Id).Contains(g.Id)))
            //    .ThenInclude(g => g.DifficultyLevel)
            //.Include(c => c.Games.Where(g => filteredGames.Select(fg => fg.Id).Contains(g.Id)))
            //    .ThenInclude(g => g.GameType)
            //.Include(c => c.Games.Where(g => filteredGames.Select(fg => fg.Id).Contains(g.Id)))
            //    .ThenInclude(g => g.Results)
            //.Include(c => c.Games.Where(g => filteredGames.Select(fg => fg.Id).Contains(g.Id)))
            //    .ThenInclude(g => g.AllowedUsers)
            //.ToListAsync();

            //Alternativ query
            //List<GameModel> games = await _context.Games_2.
            //    Include(g => g.Category).
            //    Include(g => g.GameType).
            //    Include(g => g.DifficultyLevel).
            //    Include(g => g.Items).
            //    Include(g => g.Results.Where(r => r.UserId == userId)).
            //    Include(g => g.AllowedUsers.Where(u => u.UserId == userId)).
            //    ToListAsync();
        }
    }
}

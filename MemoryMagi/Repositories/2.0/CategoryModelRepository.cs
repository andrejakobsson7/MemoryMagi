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

        public async Task<List<CategoryModel>> GetAllCategoriesAsync(string userId)
        {
            return await _context.Categories_2.
                Include(c => c.Games).
                    ThenInclude(g => g.DifficultyLevel).
                Include(c => c.Games).
                    ThenInclude(g => g.GameType).
                Include(c => c.Games).
                    ThenInclude(g => g.Results.Where(r => r.UserId == userId)).
                Include(c => c.Games).
                    ThenInclude(g => g.AllowedUsers.Where(u => u.UserId == userId)).
                Include(c => c.Games.Where(g => g.CreatedBy == userId)).
                    ToListAsync();

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

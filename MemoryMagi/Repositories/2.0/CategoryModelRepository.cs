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

        public async Task<List<CategoryModel>> GetAllCategoriesWithIncludedDataAsync(string userId)
        {
            //Get categories and their related games that the user has either created, are public or that the user has been invited to.
            //Then get the related data for these games and return it.
            //Only include results that belongs to the specific user.
            //Only get categories that has games (count over 0).

            return await _context.Categories.Where(c => c.Games.Count > 0)
                .Include(c => c.Games.Where(g => g.CreatedBy == userId ||
                                                 g.AllowedUsers.Any(u => u.UserId == userId) ||
                                                 g.GameType.ToLower() == "private" ||
                                                 g.GameType.ToLower() == "public"))
                    .ThenInclude(g => g.DifficultyLevel)
                .Include(c => c.Games.Where(g => g.CreatedBy == userId ||
                                                 g.AllowedUsers.Any(u => u.UserId == userId) ||
                                                 g.GameType.ToLower() == "private" ||
                                                 g.GameType.ToLower() == "public"))
                    .ThenInclude(g => g.Results.Where(r => r.UserId == userId))
            .ToListAsync();
        }
    }
}

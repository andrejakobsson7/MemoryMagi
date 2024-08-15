using MemoryMagi.Database;
using MemoryMagi.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public AppDbContext _context { get; set; }

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategoriesAsync(int userId)
        {
            return await _context.Categories.
                Include(c => c.Items).
                ThenInclude(i => i.UserItems.Where(u => u.UserId == userId)).
                ToListAsync();
        }

        public async Task<Category> AddCategoryAsync(Category newCategory)
        {
            try
            {
                await _context.Categories.AddAsync(newCategory);
                await _context.SaveChangesAsync();
                return newCategory;
            }
            catch (Exception ex)
            {
                throw new DbUpdateException($"Something went wrong when saving to the database. Detailed information about the exception:\n{ex.Message}\nInner exception:\n{ex.InnerException.Message}");
            }
        }
    }
}

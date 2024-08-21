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
        /// <summary>
        /// Method to retrieve all categories along with their items and user items, 
        /// which is needed in order to be able to determine whether the user has completed a category/item or not.
        /// Only take categories that the user has created or where the userid is null. Userid null means that it's a public game that everyone can play.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }
        /// <summary>
        /// Method to add a new category. 
        /// The category sent along should contain a list of items which should be automatically added to the items table when the category is saved.
        /// </summary>
        /// <param name="newCategory"></param>
        /// <returns></returns>
        /// <exception cref="DbUpdateException"></exception>
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

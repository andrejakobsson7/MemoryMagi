using MemoryMagi.Database;
using MemoryMagi.Models;

namespace MemoryMagi.Repositories
{
    public interface ICategoryRepository
    {
        public AppDbContext _context { get; set; }

        /// <summary>
        /// Method to retrieve all categories along with their items and user items, 
        /// which is needed in order to be able to determine whether the user has completed a category/item or not.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<Category>> GetAllCategoriesAsync(int userId);

        /// <summary>
        /// Method to add new category
        /// </summary>
        /// <param name="newCategory"></param>
        /// <returns></returns>
        public Task<Category> AddCategoryAsync(Category newCategory);
    }
}

using MemoryMagi.Database;
using MemoryMagi.Models;

namespace MemoryMagi.Repositories._2._0
{
    public interface ICategoryModelRepository
    {
        public AppDbContext _context { get; set; }

        public Task<List<CategoryModel>> GetAllCategoriesAsync(string userId);

    }
}

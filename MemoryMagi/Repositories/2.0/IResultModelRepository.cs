using MemoryMagi.Database;
using MemoryMagi.Models;

namespace MemoryMagi.Repositories._2._0
{
    public interface IResultModelRepository
    {
        public AppDbContext _context { get; set; }

        public Task<List<ResultModel>> GetAllResultsWithIncludedData(string userId, int currentResultId);

        public Task<List<ResultModel>> GetUserResultsForAllGames(string userId);

    }
}

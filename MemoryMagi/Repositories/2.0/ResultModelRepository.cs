using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Repositories._2._0;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public class ResultModelRepository : IResultModelRepository
    {
        public AppDbContext _context { get; set; }
        public GenericRepository<ResultModel> _genericRepository { get; set; }
        public ResultModelRepository(AppDbContext context, GenericRepository<ResultModel> genericRepository)
        {
            _context = context;
            _genericRepository = genericRepository;
        }

        public async Task<List<ResultModel>> GetAllResultsWithIncludedData(string userId, int currentResultId)
        {
            //Hämta aktuellt resultat för att i steg 2 kunna filtrera på samma game id.
            ResultModel? currentResult = await _genericRepository.GetModelById(currentResultId);
            if (currentResult == null)
            {
                throw new ArgumentException($"Result with id {currentResultId} could not be found.");
            }
            else
            {
                //Ta med alla resultat, användaren och användarens achievements. Ta bara med spel som man klarat av (passed = true)
                //Sortera på tid
                return await _context.Results.Where(r => r.GameId == currentResult.GameId && r.Passed == true)
                    .Include(r => r.Game)
                    .ThenInclude(g => g.DifficultyLevel)
                    .Include(r => r.User)
                    .ThenInclude(u => u.UserAchievements.Where(ua => ua.UserId == currentResult.UserId))
                    .OrderBy(r => r.Time)
                    .ToListAsync();
            }
        }

    }
}

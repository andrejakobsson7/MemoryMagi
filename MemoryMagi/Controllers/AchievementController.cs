using MemoryMagi.Database;
using MemoryMagi.Models._2._0;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly GenericRepository<AchievementModel> _achievementRepository;

        public AchievementController(AppDbContext context, GenericRepository<AchievementModel> achievementRepository)
        {
            _context = context;
            _achievementRepository = achievementRepository;
        }

        [HttpGet("GetAllAchievements")]
        public async Task<IActionResult> GetAllItems()
        {
            List<AchievementModel> allAchievements = await _achievementRepository.GetAll();

            if (allAchievements == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(allAchievements);
            }
        }

        [HttpPost("Achievement")]
        public async Task<ActionResult> PostAchievement([FromBody] AchievementViewModel newAchievement)
        {
            if (newAchievement == null)
            {
                return BadRequest();
            }

            AchievementModel model = new()
            {
                Name = newAchievement.Name,
                Description = newAchievement.Description,
            };

            await _achievementRepository.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }
    }

    public class AchievementViewModel
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
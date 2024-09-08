using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DifficultyLevelController : ControllerBase
    {
        private readonly GenericRepository<DifficultyLevelModel> _genericRepository;
        public DifficultyLevelController(GenericRepository<DifficultyLevelModel> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet("GetAllDifficultyLevels")]
        public async Task<IActionResult> GetAllDifficultyLevelsAsync()
        {
            try
            {
                List<DifficultyLevelModel> allDifficultyLevels = await _genericRepository.GetAll();
                if (allDifficultyLevels == null || allDifficultyLevels.Count <= 0)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(allDifficultyLevels);
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error when trying to fetch all difficulty levels.");
            }

        }
    }
}

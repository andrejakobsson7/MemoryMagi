using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MemoryMagi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly GenericRepository<ResultModel> _resultRepository;
        public ResultController(AppDbContext context, GenericRepository<ResultModel> resultRepository)
        {
            _context = context;
            _resultRepository = resultRepository;
        }


        [HttpGet("GetAllResults")]
        public async Task<IActionResult> GetAllItems()
        {

            List<ResultModel> allResults = await _resultRepository.GetAll();

            if (allResults == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(allResults);
            }

        }

        [HttpPost("Result")]
        public async Task<ActionResult> PostCategory([FromBody] ResultViewModel newResult)
        {
            if (newResult == null)
            {
                return BadRequest();
            }

            ResultModel model = new()
            {
                GameId = newResult.GameId,
                UserId = newResult.UserId,
                Time = newResult.Time,
                DatePlayed = DateTime.Now,
                Passed = newResult.Passed,
            };

            await _resultRepository.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

    }

    public class ResultViewModel
    {
        public int GameId { get; set; }
        public string UserId { get; set; } = null!;
        public TimeSpan Time { get; set; }
        public bool Passed { get; set; }
    }
}

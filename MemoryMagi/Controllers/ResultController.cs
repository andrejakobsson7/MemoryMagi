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
        public async Task<IActionResult> GetAllResults()
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
        public async Task<ActionResult> PostResult([FromBody] ResultViewModel newResult)
        {
            if (newResult == null)
            {
                return BadRequest();
            }

            if (!TimeSpan.TryParse(newResult.Time, out TimeSpan timeSpan))
            {
                return BadRequest("Invalid time format. Expected format is hh:mm:ss.");
            }

            ResultModel model = new ResultModel()
            {
                GameId = newResult.GameId,
                UserId = newResult.UserId,
                Time = timeSpan,
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
        public string Time { get; set; } = null!;
        public bool Passed { get; set; }
    }
}

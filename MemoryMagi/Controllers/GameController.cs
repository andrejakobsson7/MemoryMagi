using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GameController : ControllerBase
    {
        private readonly GenericRepository<GameModel> _genericRepository;
        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true,
        };

        public GameController(GenericRepository<GameModel> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        // För Tim eller Ludde
        [HttpPost("PostGame")]
        public async Task<IActionResult> PostNewGame([FromBody] GameModel newGame)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized();
            }
            else
            {
                newGame.CreatedBy = userId;
                try
                {
                    await _genericRepository.Add(newGame);
                    var addedGameJson = JsonSerializer.Serialize(newGame, _jsonSerializerOptions);
                    return StatusCode(201, addedGameJson);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}

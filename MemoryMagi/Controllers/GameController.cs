using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GameController : ControllerBase
    {
        private readonly GenericRepository<GameModel> _genericRepository;

        public GameController(GenericRepository<GameModel> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        // För Tim eller Ludde
        [HttpPost("PostGame")]
        public async Task<IActionResult> PostNewGame([FromBody] GameModel newGame)
        {
            if (string.IsNullOrEmpty(newGame.CreatedBy) || newGame.CategoryId <= 0)
            {
                return BadRequest("Spel måste innehålla data");
            }
            else
            {
                await _genericRepository.Add(newGame);

                return Ok("Game skapat");

            }
        }

        [HttpPost("PostGameWithId")]
        public async Task<IActionResult> PostGameWithId([FromBody] GameModel newGame)
        {
            if (string.IsNullOrEmpty(newGame.CreatedBy) || newGame.CategoryId <= 0)
            {
                return BadRequest("Spel måste innehålla data");
            }
            else
            {
                await _genericRepository.Add(newGame);

                if (newGame.Id <= 0)
                {
                    return StatusCode(500, "Failed to retrieve the game ID.");
                }

                return Ok(new { Id = newGame.Id, Message = "Game skapat och ID returnerat" });
            }
        }

    }
}
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
                    //Serialize with preserve options to avoid cycles
                    string newGameJson = JsonSerializer.Serialize(newGame, _jsonSerializerOptions);
                    return StatusCode(201, newGameJson);
                }
                catch (Exception ex)
                {
                    return BadRequest($"The following error occured while saving game: {ex.InnerException.Message}");
                }
            }
        }

        [HttpDelete("DeleteGame")]
        public async Task<IActionResult> DeleteGameAsync(int gameId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized();
            }
            else
            {
                try
                {
                    await _genericRepository.Delete(gameId);
                    return Ok("Game was successfully deleted");
                }
                catch (Exception ex)
                {
                    return BadRequest($"The following error occured while trying to delete game with id {gameId}: {ex.Message}");
                }
            }

        }
        //[HttpPost("PostGameWithId")]
        //public async Task<IActionResult> PostGameWithId([FromBody] GameModel newGame)
        //{
        //    if (string.IsNullOrEmpty(newGame.CreatedBy) || newGame.CategoryId <= 0)
        //    {
        //        return BadRequest("Spel måste innehålla data");
        //    }
        //    else
        //    {
        //        await _genericRepository.Add(newGame);

        //        if (newGame.Id <= 0)
        //        {
        //            return StatusCode(500, "Failed to retrieve the game ID.");
        //        }

        //        return Ok(new { Id = newGame.Id, Message = "Game skapat och ID returnerat" });
        //    }
        //}

        [HttpGet("GetAllGames")]
        public async Task<IActionResult> GetAllGamesAsync()
        {
            try
            {
                List<GameModel> allGames = await _genericRepository.GetAll();
                if (allGames == null)
                {
                    return NoContent();
                }

                return Ok(allGames);
            }
            catch (Exception ex)
            {
                return BadRequest($"The following error occurred while fetching games: {ex.Message}");
            }
        }

    }
}
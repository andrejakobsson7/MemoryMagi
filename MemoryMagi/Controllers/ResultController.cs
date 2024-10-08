﻿using MemoryMagi.Controllers.ApiModels;
using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Repositories;
using MemoryMagi.Repositories._2._0;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MemoryMagi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly GenericRepository<ResultModel> _resultRepository;
        private readonly IResultModelRepository _resultModelRepository;
        public ResultController(AppDbContext context, GenericRepository<ResultModel> resultRepository, IResultModelRepository resultModelRepository)
        {
            _context = context;
            _resultRepository = resultRepository;
            _resultModelRepository = resultModelRepository;
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

        [HttpGet("GetAllResultsWithIncludedData")]
        public async Task<IActionResult> GetAllResultsWithIncludedDataAsync(int currentResultId)
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
                    List<ResultModel> allResults = await _resultModelRepository.GetAllResultsWithIncludedData(userId, currentResultId);
                    //Konvertera till API-modell för enklare data till frontend.
                    List<ResultApiModel> allApiResults = allResults.Select(r => new ResultApiModel(r)).ToList();
                    return Ok(allApiResults);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpGet("GetUserResultsForAllGames")]
        public async Task<IActionResult> GetUserResultsForAllGames()
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
                    List<ResultModel> allResults = await _resultModelRepository.GetUserResultsForAllGames(userId);
                    //Konvertera till API-modell för enklare data till frontend.
                    List<ResultApiModel> allApiResults = allResults.Select(r => new ResultApiModel(r)).ToList();
                    return Ok(allApiResults);
                }
                catch (Exception)
                {
                    return StatusCode(500, "Internal server error while attempting to get all results for user");
                }
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
        public string? DifficultyLevel { get; set; }
    }
}

using MemoryMagi.Models;
using MemoryMagi.Repositories;
using MemoryMagi.Repositories._2._0;
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
    public class CategoryController : ControllerBase
    {
        private readonly IGameModelRepository _gameModelRepository;
        private readonly GenericRepository<CategoryModel> _genericRepository;
        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve
        };

        public CategoryController(IGameModelRepository gameModelRepository, GenericRepository<CategoryModel> genericRepository)
        {
            _gameModelRepository = gameModelRepository;
            _genericRepository = genericRepository;
        }

        ////[HttpGet(Name = "GetAllCategories")]
        ////public async Task<IActionResult> GetAllItems()
        ////{

        ////    List<Category> AllCategories = await _categoryRepository.GetAllCategoriesAsync();

        ////    if (AllCategories == null)
        ////    {
        ////        return BadRequest();
        ////    }
        ////    else
        ////    {
        ////        return Ok(AllCategories);
        ////    }
        //}

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized();
            }
            else
            {
                List<GameModel> allGames = await _gameModelRepository.GetAllGamesWithIncludedDataAsync(userId);
                if (allGames == null)
                {
                    return BadRequest(allGames);
                }
                else
                {
                    var allCategories = allGames.Select(g => g.Category).Distinct().ToList();
                    var categoriesJson = JsonSerializer.Serialize(allGames, _jsonSerializerOptions);
                    return Ok(categoriesJson);
                }
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddCategoryAsync(CategoryModel newCategory)
        {
            try
            {
                await _genericRepository.Add(newCategory);
                return StatusCode(201, newCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

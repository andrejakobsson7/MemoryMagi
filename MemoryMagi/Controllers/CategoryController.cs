using MemoryMagi.Controllers.ApiModels;
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
        private readonly ICategoryModelRepository _categoryModelRepository;
        private readonly GenericRepository<CategoryModel> _genericRepository;
        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true,
        };

        public CategoryController(ICategoryModelRepository categoryModelRepository, GenericRepository<CategoryModel> genericRepository)
        {
            _categoryModelRepository = categoryModelRepository;
            _genericRepository = genericRepository;
        }

        [HttpGet("GetCategoriesWithIncludedData")]
        //For usage in start quiz-page
        public async Task<IActionResult> GetAllCategoriesWithIncludedDataAsync()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized();
            }
            else
            {
                List<CategoryModel> allCategories = await _categoryModelRepository.GetAllCategoriesWithIncludedDataAsync(userId);
                if (allCategories == null)
                {
                    return BadRequest(allCategories);
                }
                else
                {
                    //Convert to api models
                    List<CategoryApiModel> apiCategories = allCategories.Select(c => new CategoryApiModel(c)).ToList();
                    //Serialize to avoid cycles
                    var categoriesJson = JsonSerializer.Serialize(apiCategories, _jsonSerializerOptions);
                    return Ok(categoriesJson);
                }
            }

        }

        [HttpGet("GetCategories")]
        //For usage when creating games
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            List<CategoryModel> allCategories = await _genericRepository.GetAll();
            if (allCategories == null)
            {
                return BadRequest("No categories found");
            }
            else
            {
                return Ok(new { UserId = userId, Categories = allCategories });
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

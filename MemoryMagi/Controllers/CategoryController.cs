using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync(int userId)
        {
            List<Category> allCategories = await _categoryRepository.GetAllCategoriesAsync(userId);
            if (allCategories == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(allCategories);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category newCategory)
        {
            try
            {
                var addedCategory = await _categoryRepository.AddCategoryAsync(newCategory);
                if (addedCategory == null)
                {
                    return StatusCode(500, addedCategory);
                }
                return StatusCode(201, addedCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

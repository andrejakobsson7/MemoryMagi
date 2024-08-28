using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Authorization;
using MemoryMagi.Repositories._2._0;
using Microsoft.AspNetCore.Mvc;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryModelRepository _categoryModelRepository;
        private readonly GenericRepository<CategoryModel> _genericRepository;
        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true,
        };

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [HttpGet(Name = "GetAllCategories")]
        public async Task<IActionResult> GetAllItems()
        {

            List<Category> AllCategories = await _categoryRepository.GetAllCategoriesAsync();

            if (AllCategories == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(AllCategories);
            }

        }

        [Authorize]
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

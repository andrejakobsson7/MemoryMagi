using MemoryMagi.Models;
using MemoryMagi.Repositories;
using MemoryMagi.Repositories._2._0;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryModelRepository _categoryModelRepository;
        private readonly GenericRepository<CategoryModel> _genericRepository;

        public CategoryController(ICategoryModelRepository categoryModelRepository, GenericRepository<CategoryModel> genericRepository)
        {
            _categoryModelRepository = categoryModelRepository;
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
                List<CategoryModel> allCategories = await _categoryModelRepository.GetAllCategoriesAsync(userId);
                if (allCategories == null)
                {
                    return BadRequest(allCategories);
                }
                else
                {
                    return Ok(allCategories);
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

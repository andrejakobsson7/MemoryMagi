using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository, SignInManager<IdentityUser> signInManager)
        {
            _categoryRepository = categoryRepository;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            //Get the user information from the cookies and extract it's ID.
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return NotFound();
            }
            else
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

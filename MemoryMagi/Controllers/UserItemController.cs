using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserItemController : ControllerBase
    {
        private readonly IUserItemRepository _userItemRepository;

        public UserItemController(IUserItemRepository userItemRepository)
        {
            _userItemRepository = userItemRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddUserItemsAsync(List<UserItem> userItems)
        {
            if (userItems == null)
            {
                return BadRequest();
            }
            else
            {
                try
                {
                    var addedUserItems = await _userItemRepository.AddUserItemsAsync(userItems);
                    if (addedUserItems == null)
                    {
                        return BadRequest();
                    }
                    else
                    {
                        return StatusCode(201, addedUserItems);
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}

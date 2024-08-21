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


        [HttpGet(Name = "GetAllUserItemsByUserId")]
        public async Task<IActionResult> GetAllItems(string userId)
        {
            // Get the UserItems that match the given UserId
            List<UserItem> userItems = await _userItemRepository.GetUserItemsByUserId(userId);

            if (userItems == null || !userItems.Any())
            {
                return NotFound();  // Use NotFound if no items are found
            }

            // Extract the ItemIds from the UserItems
            List<int> itemIds = userItems.Select(ui => ui.ItemId).ToList();

            // Return the list of ItemIds
            return Ok(itemIds);
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

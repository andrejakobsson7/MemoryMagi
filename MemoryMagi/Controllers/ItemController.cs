using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Mvc;



namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemRepository _itemRepository;
        public ItemController(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }


        [HttpGet(Name = "GetAllItems")]
        public async Task<IActionResult> GetAllItems()
        {

            List<Item> allItems = await _itemRepository.GetAllItemsAsync();

            if (allItems == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(allItems);
            }

        }

    }
}

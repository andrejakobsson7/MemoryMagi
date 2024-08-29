using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        [HttpGet("GettItemFromGameId")]
        public async Task<IActionResult> GetItemsFromgameId(int gameid)
        {

            List<ItemModel> allItems = await _itemRepository.GetAllitemsFromGameId(gameid);

            if (allItems == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(allItems);
            }

        }


        [HttpGet("GetAllItems")]
        public async Task<IActionResult> GetAllItems()
        {

            List<ItemModel> allItems = await _itemRepository.GetAllItemsAsync();

            if (allItems == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(allItems);
            }

        }

        [HttpPost("AddItem")]
        public async Task<IActionResult> AddItem([FromBody] ItemModel item)
        {
            if (item == null)
            {
                return BadRequest("Item is null.");
            }

            try
            {
                var addedItem = await _itemRepository.AddItemAsync(item);
                return CreatedAtAction(nameof(GetItemsFromgameId), new { gameid = addedItem.GameId }, addedItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
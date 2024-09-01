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
        private readonly GenericRepository<ItemModel> _genericRepository;
        public ItemController(ItemRepository itemRepository, GenericRepository<ItemModel> genericRepository)
        {
            _itemRepository = itemRepository;
            _genericRepository = genericRepository;
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
            List<ItemModel> allItems = await _genericRepository.GetAll();
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
                await _genericRepository.Add(item);
                return StatusCode(201, item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}

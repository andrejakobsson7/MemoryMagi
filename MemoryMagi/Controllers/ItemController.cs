using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemRepository _itemRepository;
        private readonly GenericRepository<Item> _genericRepository;
        public ItemController(ItemRepository itemRepository, GenericRepository<Item> genericRepository)
        {
            _itemRepository = itemRepository;
            _genericRepository = genericRepository; // För att använda generic
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

        // För Tim
        [HttpGet("GetSpecItems")]
        [Authorize]
        public async Task<IActionResult> GetItemsByGameId(int id)
        {
            GameModel getGameId = await _genericRepository.GetGameIds(id);

            if (getGameId == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(id);
            }


        }




    }
}

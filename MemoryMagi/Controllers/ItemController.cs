using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MemoryMagi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _itemRepository.GetAllItemsAsync();
            if (items == null)
            {
                return NotFound();
            }
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _itemRepository.GetItemByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(Item newItem)
        {
            if (newItem == null)
            {
                return BadRequest();
            }

            var addedItem = await _itemRepository.AddItemAsync(newItem);
            return CreatedAtAction(nameof(GetItem), new { id = addedItem.Id }, addedItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, Item updatedItem)
        {
            if (id != updatedItem.Id || updatedItem == null)
            {
                return BadRequest();
            }

            var existingItem = await _itemRepository.GetItemByIdAsync(id);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _itemRepository.UpdateItemAsync(updatedItem);
            return NoContent();
        }
    }
}

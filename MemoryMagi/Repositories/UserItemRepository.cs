using MemoryMagi.Database;
using MemoryMagi.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public class UserItemRepository : IUserItemRepository
    {
        public AppDbContext _context { get; set; }

        public UserItemRepository(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Method that receives a list of useritems to be added as the user's responses.
        /// A check is in place to ensure that the record is updated if it exists from before, and a new entry is added if it's the first time the user answers this item.
        /// </summary>
        /// <param name="userItems"></param>
        /// <returns></returns>
        /// <exception cref="DbUpdateException"></exception>
        /// <exception cref="Exception"></exception>
        public async Task<List<UserItem>> AddUserItemsAsync(List<UserItem> userItems)
        {
            try
            {
                foreach (var userItem in userItems)
                {
                    UserItem? ui = await GetUserItemByIds(userItem.UserId, userItem.ItemId);
                    if (ui == null)
                    {
                        await _context.AddAsync(userItem);
                    }
                    else
                    {
                        ui.IsComplete = userItem.IsComplete;
                        _context.UserItems.Update(ui);
                    }
                }
                await _context.SaveChangesAsync();
                return userItems;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException($"Something went wrong when saving to the database: Detailed information about the exception:\n{ex.Message}\nInner exception:\n{ex.InnerException.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<UserItem?> GetUserItemByIds(string userId, int itemId)
        {
            return await _context.UserItems.FirstOrDefaultAsync(ui => ui.UserId == userId && ui.ItemId == itemId);
        }
    }
}

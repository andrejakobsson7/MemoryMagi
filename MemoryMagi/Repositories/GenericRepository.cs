using MemoryMagi.Database;
using MemoryMagi.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetModelById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public T? GetModelByIdSynchronously(int id)
        {
            return _dbSet.Find(id);
        }

        // Hämta: Game-ID med allt från GameModel - för Tim?
        public async Task<GameModel?> GetGameIds(int gameId)
        {
            // Hämta allt i GameModel - Include:a allt
            return await _context.Set<GameModel>()
                .Include(game => game.Items)
                .Include(g => g.Category)
                .Include(g => g.DifficultyLevel)
                .Include(g => g.GameType)
                .Include(g => g.User)
                .Include(g => g.Items)
                .Include(g => g.Results)
                .Include(g => g.AllowedUsers)
                .FirstOrDefaultAsync(g => g.Id == gameId);

        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T? entityToDelete = await GetModelById(id);

            if (entityToDelete != null)
            {
                if (!_context.Set<T>().Local.Contains(entityToDelete))
                {
                    _context.Set<T>().Attach(entityToDelete);
                }

                _context.Set<T>().Remove(entityToDelete);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException($"{typeof(T).Name} with id {id} does not exist and could not be deleted");
            }
        }

        public void Update(T entity)
        {
            // Attach the entity to the _context if it's not already being tracked
            if (!_dbSet.Local.Any(e => e.Equals(entity)))
            {
                _dbSet.Attach(entity);
            }

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}

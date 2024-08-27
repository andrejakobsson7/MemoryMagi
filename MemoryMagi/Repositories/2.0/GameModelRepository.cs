using MemoryMagi.Database;
using MemoryMagi.Repositories._2._0;

namespace MemoryMagi.Repositories
{
    public class GameModelRepository : IGameModelRepository
    {
        public AppDbContext _context { get; set; }

        public GameModelRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}

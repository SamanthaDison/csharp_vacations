using System.Data;

namespace csharp_vacations.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly IDbConnection _db;
        protected BaseRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}
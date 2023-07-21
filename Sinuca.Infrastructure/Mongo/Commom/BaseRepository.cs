using Sinuca.Application.Interfaces;

namespace Sinuca.Infrastructure.Mongo.Commom
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly IMongoContext _context;

        protected BaseRepository(IMongoContext context)
        {
            _context = context;
        }
    }
}

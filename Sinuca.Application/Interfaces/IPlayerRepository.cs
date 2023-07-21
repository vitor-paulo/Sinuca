using MongoDB.Bson;
using Sinuca.Domain.Entities;

namespace Sinuca.Application.Interfaces
{
    public interface IPlayerRepository : IBaseRepository<BsonDocument>
    {
        Task<bool> CreateAsync(Player player);

        Task<Player> FindAsync(string id);
    }
}

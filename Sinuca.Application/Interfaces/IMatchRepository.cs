using MongoDB.Bson;
using Sinuca.Domain.Entities;

namespace Sinuca.Application.Interfaces
{
    public interface IMatchRepository : IBaseRepository<BsonDocument>
    {
        Task<bool> CreateAsync(Match match);
        Task<bool> CloseMatch(Match match);
        Task<bool> AddPointPlayer1(Match match);
    }
}

using MongoDB.Bson;
using MongoDB.Driver;
using Sinuca.Application.Interfaces;
using Sinuca.Domain.Entities;
using Sinuca.Infrastructure.Mongo.Commom;

namespace Sinuca.Infrastructure.Mongo.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        private readonly IMongoCollection<Player> _collection;
        private readonly string _collectionName = "players";
        public PlayerRepository(IMongoContext context) : base(context)
        {
            _collection = _context.GetCollection<Player>(_collectionName);
        }

        public async Task<bool> CreateAsync(Player player)
        {
            await _collection.InsertOneAsync(player, options: null);
            return true;
        }

        public async Task<Player> FindAsync(string id)
        {
            var filter = GenerateFilter(id);

            return await _collection
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        private static FilterDefinition<Player> GenerateFilter(string id)
        {
            return Builders<Player>
                .Filter
                .Where(i =>i.Id == ObjectId.Parse(id));
        }
    }
}

using MongoDB.Bson;
using MongoDB.Driver;
using Sinuca.Application.Interfaces;
using Sinuca.Domain.Entities;
using Sinuca.Infrastructure.Mongo.Commom;

namespace Sinuca.Infrastructure.Mongo.Repositories
{
    internal class MatchRepository : BaseRepository<Match>, IMatchRepository
    {
        private readonly IMongoCollection<Match> _collection;
        private readonly string _collectionName = "matches";
        public MatchRepository(IMongoContext context) : base(context)
        {
            _collection = _context.GetCollection<Match>(_collectionName);
        }

        public async Task<bool> CreateAsync(Match match)
        {
            await _collection.InsertOneAsync(match, options: null);
            return true;
        }

        public async Task<bool> CloseMatch(Match match)
        {
            var filter = GenerateFilter(match.Id);
            var update = GenerateCloseDefinition(match);

            var result = await _collection.UpdateOneAsync(filter, update, options: null);

            return result.ModifiedCount != 0;
        }

        public async Task<bool> AddPointPlayer1(Match match)
        {
            var filter = GenerateFilter(match.Id);
            var update = GenerateAddPointPlayer1Definition(match);

            var result = await _collection.UpdateOneAsync(filter, update, options: null);

            return result.ModifiedCount != 0;
        }


        private static UpdateDefinition<Match> GenerateAddPointPlayer1Definition(Match match)
        {
            var update = Builders<Match>.Update;

            return update
                .Inc(_ => _.PlayerPoints1, 1);
        }

        private static UpdateDefinition<Match> GenerateCloseDefinition(Match match)
        {
            var update = Builders<Match>.Update;

            return update
                .Set(_ => _.Active, match.Active);
        }

        private static FilterDefinition<Match> GenerateFilter(ObjectId id)
        {
            return Builders<Match>
                .Filter
                .Where(i => i.Id == id);
        }
    }
}

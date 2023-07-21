using MongoDB.Driver;
using Sinuca.Application.Interfaces;

namespace Sinuca.Infrastructure.Mongo
{
    public class MongoContext : IMongoContext
    {
        private readonly IMongoDatabase _database;

        public MongoContext(IEnvironmentVariables environmentVariables)
        {

            var client = new MongoClient("mongodb://localhost:27017/");
            _database = client.GetDatabase("sinuca");
        }

        public IMongoCollection<T> GetCollection<T>(string collection)
        {
            return _database.GetCollection<T>(collection);
        }

    }
}
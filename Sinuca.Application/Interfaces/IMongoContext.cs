using MongoDB.Driver;

namespace Sinuca.Application.Interfaces
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetCollection<T>(string collection);
    }
}

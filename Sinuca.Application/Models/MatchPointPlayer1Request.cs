using MongoDB.Bson;
using Sinuca.Domain.Entities;

namespace Sinuca.Application.Models
{
    public class MatchPointPlayer1Request
    {
        public string IdMatch { get; set; }

        public Match AddPoint() => new()
        {
            Id = ObjectId.Parse(IdMatch),
        };
    }
}

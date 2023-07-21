using MongoDB.Bson;
using Sinuca.Domain.Entities;

namespace Sinuca.Application.Models
{
    public class MatchCloseRequest
    {
        public string IdMatch { get; set; }

        public Match Close() => new()
        {
            Id = ObjectId.Parse(IdMatch),
            Active = false
        };
    }
}

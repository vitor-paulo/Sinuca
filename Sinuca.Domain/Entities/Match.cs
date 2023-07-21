using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sinuca.Domain.Entities
{
    public class Match
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("player_1")]
        public Player Player1 { get; set; }

        [BsonElement("player_2")]
        public Player Player2 { get; set; }

        [BsonElement("player_points_1")]
        public int PlayerPoints1 { get; set; }

        [BsonElement("player_points_2")]
        public int PlayerPoints2 { get; set; }

        [BsonElement("active")]
        public bool Active { get; set; }
    }
}

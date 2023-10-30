using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Rebar.Model
{
    public class Menu
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement("shakes")]
        public List<Shake> Shakes { get; set; }
    }
}

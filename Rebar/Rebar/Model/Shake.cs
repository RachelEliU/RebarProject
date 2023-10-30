
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace RebarProject.Models
{
    [BsonIgnoreExtraElements]
    public class Shake
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("description")]

        public string Description { get; set; }
        [BsonElement("priceL")]
        public int PriceL { get; set; }
        [BsonElement("priceM")]

        public int PriceM { get; set; }
        [BsonElement("priceS")]

        public int PriceS { get; set; }

    }
}

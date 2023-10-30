using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace RebarProject.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement("shakes")]
        public List<Shake> Shakes { get; set; }
        [BsonElement("clientname")]
        public string ClientName { get; set; }
        [BsonElement("totalcost")]
        public double TotalCost { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("discout")]
        public List<String> Discount { get; set; }
    }
}

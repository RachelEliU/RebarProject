using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace RebarProject.Models
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement("orders")]
        public List<Order> Orders { get; set; }= new List<Order>();
        [BsonElement("sum")]
        public double Sum {  get; set; }
        public Account()
        {
            Id = Guid.NewGuid();
        }
    }
}

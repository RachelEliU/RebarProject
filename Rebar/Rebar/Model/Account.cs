using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Rebar.Model
{
    public class Account
    {
       // [BsonId]
      //  [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement("orders")]
        public List<Order> Orders { get; set; }= new List<Order>();
        [BsonElement("sum")]
        public double Sum { get; set; } = 0;
        public Account()
        {
            Id = Guid.NewGuid();
        }
    }
}

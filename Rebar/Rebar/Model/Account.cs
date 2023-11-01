using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Rebar.Model
{
    public class Account
    {
        [BsonId]
       [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }=Guid.NewGuid().ToString();
        [BsonElement("orders")]
        public List<Order> Orders { get; set; }= new List<Order>();
        [BsonElement("password")]
        public string Password {  get; set; }
    }
}

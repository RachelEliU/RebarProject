using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Rebar.Model;

namespace Rebar.Model
{
    public class Order
    {
        [BsonId]
       [BsonRepresentation(BsonType.String)]
        //[SwaggerSchema(ReadOnly = true)]
        public String Id { get; private set; } = Guid.NewGuid().ToString();
        [BsonElement("shakes")]
        public List<ShakeInOrder> Shakes { get; set; }= new List<ShakeInOrder>();
        [BsonElement("clientname")]
        public string ClientName { get; set; }=string.Empty;
        [BsonElement("totalcost")]
        public double TotalCost { get; set; } = 0;
        [BsonElement("dateorder")]
        public DateTime DateOrder { get; set; }= DateTime.UtcNow;
        [BsonElement("daterecive")]

        public DateTime DateRecive { get; set; }=DateTime.UtcNow;
        [BsonElement("discount")]
        public CouponsAndDiscounts Discount { get; set; }
    }
}

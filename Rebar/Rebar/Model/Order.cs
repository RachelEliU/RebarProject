using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Rebar.Model;

namespace Rebar.Model
{
    public class Order
    {
        [BsonId]
       [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; } = Guid.NewGuid();
      //  public string Id { get; set; } =Guid.NewGuid().ToString();
        [BsonElement("shakes")]
        public List<ShakeInOrder> Shakes { get; set; }= new List<ShakeInOrder>();
        [BsonElement("clientname")]
        public string ClientName { get; set; }
        [BsonElement("totalcost")]
        public double TotalCost { get; set; } = 0;
        [BsonElement("dateorder")]
        public DateTime DateOrder { get; set; }= DateTime.UtcNow;
        [BsonElement("daterecive")]

        public DateTime DateRecive { get; set; }=DateTime.UtcNow;
        [BsonElement("discout")]
        public List<CouponsAndDiscounts> Discount { get; set; }
       /* public Order(string name, List<CouponsAndDiscounts> discount)
        {
            DateOrder = DateTime.Now;
            ClientName= name;
            Discount = discount;
        }*/
    }
}

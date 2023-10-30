using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Rebar.Model;

namespace RebarProject.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement("shakes")]
        public List<ShakeInOrder> Shakes { get; set; }= new List<ShakeInOrder>();
        [BsonElement("clientname")]
        public string ClientName { get; set; }
        [BsonElement("totalcost")]
        public double TotalCost { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("discout")]
        public List<CouponsAndDiscounts> Discount { get; set; }
        public Order(string name,DateTime date, List<CouponsAndDiscounts> discount)
        {
            Id = Guid.NewGuid();
            Date = date;
            Discount = discount;
        }
    }
}

using Microsoft.Extensions.Diagnostics.HealthChecks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Rebar.Model
{
    public class CouponsAndDiscounts
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        [BsonElement("name")]
        public string Name {  get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("discount")]
        public double Discount {  get; set; }
       /* public CouponsAndDiscounts(string name, string description,double discount)
        {
            Id = Guid.NewGuid( );
            Name = name;
            Description = description;
            Discount = discount;
        }*/
    }
}


using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Rebar.Model
{
    public enum Pricing 
    {
        Small=24,
        Medium=27,
        Large=28,
    }
    [BsonIgnoreExtraElements]
    public class Shake
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
      public Guid Id { get; }= Guid.NewGuid();
      //  public string Id { get; set; }=Guid.NewGuid().ToString();
        [BsonElement("name")]
        public string Name { get; set; }
       [BsonElement("description")]

        public string Description { get; set; }
        [BsonElement("price")]
        public double Price { get; set; }

      //  [BsonElement("priceL")]
       // public int PriceL { get; set; }

      //  [BsonElement("priceM")]
      //  public int PriceM { get; set; }
      //  [BsonElement("priceS")]

       // public int PriceS { get; set; }
       public Shake(string name,string description,double price) 
        {
            Name=name;
            Description=description;
            Price=price;
        }
    }
}

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace RebarProject.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
        [BsonElement("city")]
        public string City { get; set; }
        [BsonElement("phonenumber")]
        public string PhoneNumber { get; set; }
        public Customer(string name, string adress, string city,string phone)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = adress;
            City = city;
            PhoneNumber = phone;
        }
    }
}

using MongoDB.Driver;
using RebarProject.Models;
using System;

namespace RebarProject.Services
{
    public class AccountService : IAccountService
    {
        private readonly MongoClient _client;
        private readonly IMongoCollection<Order> _orders;
        public AccountService(IRebarStoreDataBaseSetting settings, IMongoClient mongoClient)
        {
            MongoClient.
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _orders = database.GetCollection<Order>(settings.OrderCollectionName);
        }

        public Order CreateOrder(Order order)
        {
            _orders.InsertOne(order);
            return order;
        }

        public void DeleteOrder(Guid id)
        {
            _orders.DeleteOne(order => order.Id == id);
        }

        public double GetBalance()
        {
            /*int sum = 0;
            foreach(var order in _orders.Find(order => true).ToList();) 
            { 
            
            }*/
            return 0;   
        }

        public Order GetOrder(Guid id)
        {
            return _orders.Find(order => order.Id == id).FirstOrDefault();
        }

        public List<Order> GetOrders()
        {
            return _orders.Find(order => true).ToList();
        }

        public void UpdateOrder(Guid id,Order order)
        {
            _orders.ReplaceOne(order => order.Id == id, order);
        }
    }
}

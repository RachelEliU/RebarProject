using Microsoft.JSInterop;
using MongoDB.Driver;
using Rebar.Model;
using System;

namespace Rebar.Services
{
    public class AccountService : IAccountService
    {
        private readonly MongoClient _client;
        private readonly IMongoCollection<Account> _account;
        private readonly IMongoCollection<Order> _orders;
        public AccountService(IRebarStoreDataBaseSetting settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _account = database.GetCollection<Account>(settings.OrderCollectionName);
           // _orders = database.GetCollection<Order>(settings.OrderCollectionName);
        }

        public Order CreateOrder(Order order)
        {          
            _orders.InsertOne(order);
            return order;
        }

        public void DeleteOrder(string id)
        {
            _orders.DeleteOne(order => order.Id == id);
        }

        public Order GetOrder(string id)
        {
            return _orders.Find(order => order.Id == id).FirstOrDefault();
        }

        public List<Order> GetOrders()
        {
            return _orders.Find(order => true).ToList();
        }
        public List<ShakeInOrder> GetShakes(string id)
        {
            return GetOrder(id).Shakes;
        }

        public void UpdateOrder(string id, Order order)
        {
            _orders.ReplaceOne(order => order.Id == id, order);
        }

        public double GetBalance()
        {
            double sum = 0;
            foreach(var order in _orders.Find(order => true).ToList()) 
            {
                sum += order.TotalCost;
            }
            return sum;   
        }
    
    }
}

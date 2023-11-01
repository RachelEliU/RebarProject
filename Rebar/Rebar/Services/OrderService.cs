﻿using Rebar.Model;
using MongoDB.Driver;

namespace Rebar.Services

{
    public class OrderService : IOrderService
    {
        private readonly MongoClient _client;
        private readonly IMongoCollection<Order> _orders;
        private readonly IMongoCollection<Shake> _shake;
        public OrderService(IRebarStoreDataBaseSetting settings,IMongoClient mongoClient) 
        {
          var database=  mongoClient.GetDatabase(settings.DatabaseName);
           _orders= database.GetCollection<Order>(settings.OrderCollectionName);
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

        public  Order GetOrder(string id)
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
            _orders.ReplaceOne(order => order.Id  == id, order);
        }
    }
}

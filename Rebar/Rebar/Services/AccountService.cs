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

        public Account CreateAccount(Account account)
        {          
            _account.InsertOne(account);
            return account;
        }

        public void DeleteAccount(string id)
        {
            _account.DeleteOne(account => account.Id == id);
        }

        public Account GetAccount(string id)
        {
            return _account.Find(account => account.Id == id).FirstOrDefault();
        }

        public List<Account> GetAccounts()
        {
            return _account.Find(account => true).ToList();
        }
        public List<Order> GetOrders(string id)
        {
            return _account.Find(account => account.Id == id).FirstOrDefault().Orders;
        }

        public void UpdateAccount(string id, Account account)
        {
            _account.ReplaceOne(account => account.Id == id, account);
        }

        public void UpdatePassword(string id, string password)
        {
            if(password.Length > 0)
                GetAccount(id).Password = password;

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
        public void AddOrderToAccount(Order order, string id)
        {
            if(order != null)
            _account.Find(account => account.Id == id).FirstOrDefault().Orders.Add(order) ;
        }

        public string GetPasswrodAccount(string id)
        {
            return _account.Find(account => account.Id == id).FirstOrDefault().Password;
        }
        public List<Order> GetTodayOrder(string id)
        {
            List<Order> orders = new List<Order>();
            foreach(var order in _account.Find(account => account.Id == id).FirstOrDefault().Orders)
            {
                if(order.DateOrder.Equals(DateTime.Today))
                    orders.Add(order) ;
            }
            return orders;
           // return _account.Find(account => account.Id == id).FirstOrDefault().Orders.AddRange(item => item.DateOrder.Equals(DateTime.Today));
        }
        public double GetTodaySum(string id)
        {
            return GetTodayOrder(id).Sum(item => item.TotalCost);
        }
    }
}

using MongoDB.Driver;
using Rebar.Model;
using System;

namespace Rebar.Services
{
    public class AccountService : IAccountService
    {
        private readonly MongoClient _client;
        private readonly IMongoCollection<Account> _account;
        public AccountService(IRebarStoreDataBaseSetting settings, IMongoClient mongoClient)
        {

            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _account = database.GetCollection<Account>(settings.OrderCollectionName);
        }

        public Account CreateOrder(Account account)
        {
            _account.InsertOne(account);
            return account;
        }

        public void DeleteOrder(Guid id)
        {
            _account.DeleteOne(account => account.Id == id);
        }

        public double GetBalance()
        {
            /*int sum = 0;
            foreach(var order in _orders.Find(order => true).ToList();) 
            { 
            
            }*/
            return 0;   
        }

        public Account GetOrder(Guid id)
        {
            return _account.Find(account => account.Id == id).FirstOrDefault();
        }

        public List<Account> GetOrders()
        {
            return _account.Find(account => true).ToList();
        }

        public void UpdateOrder(Guid id,Account account)
        {
            _account.ReplaceOne(account => account.Id == id, account);
        }
    }
}

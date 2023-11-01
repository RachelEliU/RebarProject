using Rebar.Model;

namespace Rebar.Services
{
    public interface IAccountService
    {
       // Order CreateOrder(Order order);
        //void DeleteOrder(string id);
        //Order GetOrder(string id);
        //List<Order> GetOrders();
        //List<ShakeInOrder> GetShakes(string id);
        //void UpdateOrder(string id, Order order);
       // double GetBalance();

        Account CreateAccount(Account account);
        List<Account> GetAccounts();
        Account GetAccount(string id);
        string GetPasswrodAccount(string id);
        void UpdateAccount(string id,Account account);
        void UpdatePassword(string id, string password);
        void DeleteAccount(string id);
        void AddOrderToAccount(Order order, string id);
  }
}

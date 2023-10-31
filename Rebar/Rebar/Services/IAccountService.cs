using Rebar.Model;

namespace Rebar.Services
{
    public interface IAccountService
    {
        Order CreateOrder(Order order);
        void DeleteOrder(Guid id);
        Order GetOrder(Guid id);
        List<Order> GetOrders();
        List<ShakeInOrder> GetShakes(Guid id);
        void UpdateOrder(Guid id, Order order);
        double GetBalance();

        //Account CreateAccount(Account account);
        //List<Account> GetAccounts();
        //Account GetAccount(Guid id);
        //void UpdateAccount(Guid id,Account account);
        //void DeleteAccount(Guid id);
        //double GetBalance(DateTime dateTime);
        // Order CreateOrder(Order order);
    }
}

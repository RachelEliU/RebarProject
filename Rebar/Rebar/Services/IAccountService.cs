using Rebar.Model;

namespace Rebar.Services
{
    public interface IAccountService
    {
        List<Account> GetOrders();
        Account GetOrder(Guid id);
        Account CreateOrder(Account account);
        void UpdateOrder(Guid id,Account account);
        void DeleteOrder(Guid id);
        double GetBalance();
    }
}

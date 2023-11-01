using Rebar.Model;

namespace Rebar.Services
{
    public interface IAccountService
    {
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

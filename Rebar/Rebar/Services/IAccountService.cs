using RebarProject.Models;

namespace RebarProject.Services
{
    public interface IAccountService
    {
        List<Order> GetOrders();
        Order GetOrder(Guid id);
        Order CreateOrder(Order order);
        void UpdateOrder(Guid id,Order order);
        void DeleteOrder(Guid id);
        double GetBalance();
    }
}

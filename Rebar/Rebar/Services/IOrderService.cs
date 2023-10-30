using Rebar.Model;

namespace Rebar.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order GetOrder(Guid id);
        void DeleteOrder(Guid id);
        Order CreateOrder(Order order);
        void UpdateOrder(Guid id,Order order);
    }
}

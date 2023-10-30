using RebarProject.Models;

namespace RebarProject.Services
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

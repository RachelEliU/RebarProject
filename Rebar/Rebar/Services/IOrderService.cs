using Rebar.Model;

namespace Rebar.Services
{
    public interface IOrderService
    {
        Order CreateOrder(Order order);
        void DeleteOrder(Guid id);
        Order GetOrder(Guid id);
        List<Order> GetOrders();
        List<ShakeInOrder> GetShakes(Guid id);
        void UpdateOrder(Guid id,Order order);

        //Shake GetShake(Guid id);
        //void DeleteShake(Guid id);
        //Shake CreateShake(Shake shake);
        // void UpdateShake(Guid id, Shake shake);
    }
}

using Rebar.Model;

namespace Rebar.Services
{
    public interface IOrderService
    {
        Order CreateOrder(Order order);
        void DeleteOrder(string id);
        Order GetOrder(string id);
        List<Order> GetOrders();
        List<ShakeInOrder> GetShakes(string id);
        void UpdateOrder(string id,Order order);

        //Shake GetShake(Guid id);
        //void DeleteShake(Guid id);
        //Shake CreateShake(Shake shake);
        // void UpdateShake(Guid id, Shake shake);
    }
}

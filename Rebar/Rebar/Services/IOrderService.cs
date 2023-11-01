﻿using Rebar.Model;

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
    }
}

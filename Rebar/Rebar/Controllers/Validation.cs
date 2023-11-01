using Microsoft.Extensions.Diagnostics.HealthChecks;
using Rebar.Model;
using Rebar.Services;

namespace Rebar.Controllers
{
    public static class Validation
    {
        public const int MaxNameLatters = 100;
        public const int MaxShakeInOrder = 10;       
        public static void CheckOrder(Order order,IMenuService menuService)
        {
            double total = 0;
            if (order == null)
            {
                throw new ArgumentNullException("No Order has been recived please enter Order");
            }
            IsValidName(order.ClientName);           
            IsValidShake(order,  menuService);
            IsValidSize(order,menuService);
           total = order.Shakes.Sum(shake=>shake.Price);
        }
        public static void IsValidName(String inputName)
        {
            if (inputName == null)
            {
                throw new ArgumentNullException("No Name has been recived please enter customer name");
            }
            if(inputName.Length == 0 )
            {
                throw new ArgumentException("No Name has been recived please enter customer name");
            }
            if (inputName.Length > MaxShakeInOrder)
            {
                throw new ArgumentException($"Order can only have up to {MaxShakeInOrder} Shakes");
            }           
        }
       
        public static void IsValidShake(Order order, IMenuService _menuService)
        {

            if (order.Shakes.Count == 0)
            {
                throw new ArgumentNullException("No shake has been recived please enter shake");
            }

            if(order.Shakes.Any(item => _menuService.GetShake(item.IdShake)==null))
            {
                throw new ArgumentException("We don't have this shake in our menu, please enter a shake that is in our menu");
            }

            if (order.Shakes.Count > MaxNameLatters)
            {
                throw new ArgumentException("Name invalid, Please enter currect name");
            }
        }

        public static void IsValidSize(Order order,IMenuService menuService)
        {
            foreach(var shake in order.Shakes)
            {
                if (shake.Size == null)
                {
                    throw new ArgumentNullException("No size of shake has been recived please enter S, M or L");
                }
                if (!shake.Size.Equals("s") && !shake.Size.Equals("M") && !shake.Size.Equals("L"))
                {
                    throw new ArgumentException("size of shake must be S, M or L");
                }
            }
          //  UpdateShakePrice(order, menuService);
        }
       /* public void UpdateShakePrice(Order order , IMenuService menuService)
        {
            foreach (var shake in order.Shakes)
            {
                switch shake.Size
                    case S:

            }
                shake.Price = menuService.GetShake(shake.Id);
        }*/
    }
}

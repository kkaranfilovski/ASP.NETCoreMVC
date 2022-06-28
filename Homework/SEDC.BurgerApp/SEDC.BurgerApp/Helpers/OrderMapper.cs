using SEDC.BurgerApp.Models.Domain;
using SEDC.BurgerApp.Models.ViewModels;

namespace SEDC.BurgerApp.Helpers
{
    public static class OrderMapper
    {
        public static OrderListViewModel MapToOrderListViewModel(this Order order)
        {
            decimal price = 0;
            foreach(var burger in order.Burgers)
            {
                price += burger.Price;
            }

            return new OrderListViewModel
            {
                OrderId = order.Id,
                UserFullName = order.FullName,
                TotalPrice = price           
            };
        }

        public static OrderDetailsViewModel MapToOrderDetailsViewModel(this Order order)
        {
            decimal price = 0;
            var name = new List<string>();
            foreach (var burger in order.Burgers)
            {
                name.Add(burger.Name);
                price += burger.Price;
            }

            return new OrderDetailsViewModel
            {   
                OrderId = order.Id,
                UserFullName = order.FullName,
                TotalPrice = price,
                Address = order.Address,
                Burgers = name,
                status = order.IsDelivered
            };
        }

        public static Order MapToCreateOrder(this Order order)
        {
            var burgers = StaticDB.Burgers;

            return new Order
            {
                Burgers = burgers
            };
        }
    }
}

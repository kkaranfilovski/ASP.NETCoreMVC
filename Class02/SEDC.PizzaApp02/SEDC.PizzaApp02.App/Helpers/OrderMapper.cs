using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

namespace SEDC.PizzaApp02.App.Helpers
{
    public static class OrderMapper
    {
        public static OrderListViewModel MapToOrderListViewModel(this Order order)
        {
            return new OrderListViewModel
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}"
            };
        }

        public static OrderDetailsViewModel MapToOrderDetailsViewModel(this Order order)
        {
            return new OrderDetailsViewModel
            {
                PizzaName = order.Pizza.Name,
                UserName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price,
                Isdelivered = order.IsDelivered     
            };
        }

    }
}

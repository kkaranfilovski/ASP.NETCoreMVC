using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Helpers
{
    public static class OrderMapper
    {
        public static OrderListViewModel MapToOrderListViewModel(this Order order)
        {
            return new OrderListViewModel
            {
                Id = order.Id,
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}"
            };
        }

        public static OrderDetailsViewModel MapToOrderDetailsViewModel(this Order order)
        {
            return new OrderDetailsViewModel
            {
                Id = order.Id,
                PizzaName = order.Pizza.Name,
                UserName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.IsOnPromotion ? 200 : order.Pizza.Price,
                Isdelivered = order.IsDelivered
            };
        }

        public static Order MapToOrder(this OrderDetailsViewModel orderViewModel)
        {
            return new Order()
            {
                Id = orderViewModel.Id,
                PaymentMethod = orderViewModel.PaymentMethod,
            };
        }
    }
}

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

    }
}

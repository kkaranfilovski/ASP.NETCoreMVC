using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

namespace SEDC.PizzaApp02.App.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {

            List<Order> ordersFromDb = StaticDb.Orders;
            List<OrderListViewModel> model = new List<OrderListViewModel>();
            foreach (var order in ordersFromDb)
            {
                var orderModel = new OrderListViewModel()
                {
                    PizzaName = order.Pizza.Name,
                    UserFullName = $"{order.User.FirstName} {order.User.LastName}"
                };
                model.Add(orderModel);
            }
            return View(model);
        }
    }
}

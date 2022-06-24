using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Helpers;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> ordersFromDb = StaticDb.Orders;
            List<OrderListViewModel> orderListViewModel = ordersFromDb
                                                    .Select(x => x.MapToOrderListViewModel())
                                                    .ToList();
            ViewData.Add("Message", $"We have total orders of {orderListViewModel.Count}");
            ViewData.Add("Title", "Orders list");
            ViewData.Add("FirstUser", $"Our very first user in the system is {StaticDb.Users.FirstOrDefault()?.FirstName}");

            return View(orderListViewModel);
        }

        public IActionResult Details(int? id)
        {
            var order = StaticDb.Orders.SingleOrDefault(x => x.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            var model = order.MapToOrderDetailsViewModel();
            return View(model);
        }
    }
}

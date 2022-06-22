using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp02.App.Helpers;
using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

namespace SEDC.PizzaApp02.App.Controllers
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
    }
}

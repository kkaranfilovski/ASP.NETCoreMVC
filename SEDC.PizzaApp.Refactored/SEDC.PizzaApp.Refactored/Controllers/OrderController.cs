using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers.Extensions;
using SEDC.PizzaApp.Services.Services.Interfaces;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var orderListViewModel = _orderService.GetAllOrders();
            return View(orderListViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.HomeViewModels;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IPizzaService _pizzaService;

        public HomeController(IOrderService service, IPizzaService pizzaService)
        {
            _orderService = service;
            _pizzaService = pizzaService;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.OrderCount = _orderService.GetAllOrders().Count;
            homeViewModel.PizzaOnPromotion = string.Join(", ", _pizzaService.GetPizzasOnPromotion().Select(x => x.Name));
            return View(homeViewModel);
        }
    }
}

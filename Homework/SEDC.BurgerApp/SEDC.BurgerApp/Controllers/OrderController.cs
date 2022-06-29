using Microsoft.AspNetCore.Mvc;
using SEDC.BurgerApp.Helpers;
using SEDC.BurgerApp.Models.Domain;
using SEDC.BurgerApp.Models.ViewModels;

namespace SEDC.BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllOrders()
        {
            var orders = StaticDB.Orders;
            var model = orders.Select(x => x.MapToOrderListViewModel()).ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {

            var order = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            var model = order.MapToOrderDetailsViewModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Burgers = StaticDB.Burgers
                .Select(x => x.MapToBurgerSelectViewModel()).ToList();

            var order = new OrderViewModel();
            return View(order);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {
                StaticDB.Orders.Add(orderViewModel.MapToOrder());
                return RedirectToAction("AllOrders");
            }

            return View(orderViewModel);
        }
    }
}

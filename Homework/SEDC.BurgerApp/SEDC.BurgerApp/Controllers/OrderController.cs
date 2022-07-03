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
            ViewBag.Burgers = StaticDB.Burgers
                .Select(x => x.MapToBurgerSelectViewModel()).ToList();

            if (ModelState.IsValid)
            {
                StaticDB.Orders.Add(orderViewModel.MapToOrder());
                return RedirectToAction("AllOrders");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Burgers = StaticDB.Burgers
                .Select(x => x.MapToBurgerSelectViewModel()).ToList();

            var selectedBurgers = new List<Burger>(); 
            var order = StaticDB.Orders.SingleOrDefault(x => x?.Id == id);
            var editViewModel = order.MapToOrderViewModel();
            return View(editViewModel);
        }

        [HttpPost]
        public IActionResult Edit(OrderViewModel order)
        {
            if(ModelState.IsValid)
            {
                var orderFromDb = StaticDB.Orders.SingleOrDefault(x => x.Id == order.Id);
                var index = StaticDB.Orders.IndexOf(orderFromDb);
                var editedOrder = order.MapToOrder(order.Id);
                StaticDB.Orders[index] = editedOrder;
                return RedirectToAction("AllOrders");
            }
            ViewBag.ErrorMessage = "Order update failed";
            return View();
        }

        public IActionResult Delete(int id)
        {
            var order = StaticDB.Orders.FirstOrDefault(x => x.Id == id);
            var model = order.MapToOrderDetailsViewModel();
            return View(model);
        }

        public IActionResult ConfirmDelete(int id)
        {
            var order = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
            StaticDB.Orders.Remove(order);
            return RedirectToAction("AllOrders");
        }
    }
}

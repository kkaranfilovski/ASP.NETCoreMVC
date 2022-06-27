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

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Users = StaticDb.Users.Select(x => x.MapToUserSelectViewModel()).ToList();
            var model = new OrderViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                order.Id = StaticDb.Users.Count() + 1;
                Pizza pizzaFromDb = StaticDb.Pizzas.FirstOrDefault(x => x.Name.ToLower() == order.PizzaName.ToLower());

                if (pizzaFromDb == null)
                {
                    return View("ResourceNotFound");
                }
            }
                    
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }

            var orderFromDb = StaticDb.Orders.SingleOrDefault(x => x.Id == id);

            if(orderFromDb == null)
            {
                return View("ResourceNotFound");
            }
            var orderDetailsView = orderFromDb.MapToOrderDetailsViewModel();

            return View(orderDetailsView);
        }

        public IActionResult ConfirmDelete(int? id)
        {
            var orderFromDb = StaticDb.Orders.SingleOrDefault(x => x.Id == id);

            if(orderFromDb == null)
            {
                return View("ResourceNotFound");
            }
            StaticDb.Orders.Remove(orderFromDb);

            return RedirectToAction("Index");
        }
    }
}

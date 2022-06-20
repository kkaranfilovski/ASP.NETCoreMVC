﻿using Microsoft.AspNetCore.Mvc;
using SEDC.Class03.Demo.Models.ViewModels;

namespace SEDC.Class03.Demo.Controllers
{
    public class OrderController : Controller
    {
        
        public IActionResult OrderDetails(int id)
        {
            var order = StaticDB.Orders.SingleOrDefault(x => x.Id == id);
            var user = StaticDB.Users.SingleOrDefault(x => x.Id == id);
            OrderDetailsViewModel model = new OrderDetailsViewModel()
            {
                Id = order.Id,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                Address = order.User.Address,
                Phone = order.User.Phone,
                Price = order.Price,
                PizzaName = "Capri"
            };
            return View(model);
        }
    }
}

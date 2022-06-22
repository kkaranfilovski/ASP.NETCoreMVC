using Microsoft.AspNetCore.Mvc;
using SEDC.Class04.DEMO.Models;

namespace SEDC.Class04.DEMO.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new User
            {
                Id = 1,
                FirstName = "Kristijan",
                LastName = "Karanfilovski",
                Age = 27,
                City = "Skopje",
                IsEmployed = true,
            };
            return View(user);
        }
    }
}

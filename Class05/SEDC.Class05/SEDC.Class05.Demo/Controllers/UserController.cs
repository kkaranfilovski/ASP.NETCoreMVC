using Microsoft.AspNetCore.Mvc;
using SEDC.Class05.Demo.Models;

namespace SEDC.Class05.Demo.Controllers
{
    public class UserController : Controller
    {
        [Route("user")]
        public IActionResult Index()
        {
            var user = StaticDb.Users.SingleOrDefault(x => x.Id == 1);
            var u = new User();
            return View(user);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    user.Id = StaticDb.Users.Count + 1;
                    StaticDb.Users.Add(user);
                    return RedirectToAction("Users");
                }
            }
            return View();
        }

        [HttpGet("all")]
        public IActionResult Users()
        {
            var users = StaticDb.Users;
            return View(users);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = StaticDb.Users.SingleOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (user != null)
            {
                var userFromDb = StaticDb.Users.SingleOrDefault(x => x.Id == user.Id);
                userFromDb.FirstName = user.FirstName;
                userFromDb.LastName = user.LastName;
                userFromDb.Age = user.Age;
                userFromDb.City = user.City;
                return RedirectToAction("Users");
            }
            ViewBag.ErrorMessage = "User update failed! Contact support!";
            return View();
        }
    }
}

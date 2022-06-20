using Microsoft.AspNetCore.Mvc;
using SEDC.Class03.Demo.Models;
using System.Diagnostics;

namespace SEDC.Class03.Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUserById(int id)
        {
            var user = StaticDB.Users.SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public IActionResult GetUserByName(string firstname)
        {
            var user = StaticDB.Users.FirstOrDefault(x => x.FirstName == firstname);
            if (user == null)
            {
                return NotFound();
            }

            return View("GetUserBzId", user);
        }

        public IActionResult DisplayName(string firstName)
        {
            var user = StaticDB.Users.FirstOrDefault(x => x.FirstName == firstName);
            ViewData.Add("FirstName", firstName);
            ViewData.Add("User", user);
            return View();
        }

        public IActionResult DisplayData(int id)
        {
            var user = StaticDB.Users.SingleOrDefault(x => x.Id == id);
            ViewBag.User = user;
            ViewBag.Date = DateTime.Now.ToShortDateString();
            if (user == null)
            {
                return NotFound();
            }
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace SEDC.Class02.Demo.Controllers
{
    //[Route("App/[Action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult EmptyRoute()
        {
            return new EmptyResult();
        }

        public IActionResult TakeMeToHomePage()
        {
            return RedirectToAction("Index");
        }

        public IActionResult JsonResult()
        {
            var user = new { Id = 1, FullName = "Martin Panovski", Age = 27 };
            return new JsonResult(user);
        }

        public IActionResult TakeMeToUserPage()
        {
            return RedirectToAction("Index", "User");
        }
    }
}

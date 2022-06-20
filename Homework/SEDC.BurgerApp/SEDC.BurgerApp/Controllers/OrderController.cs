using Microsoft.AspNetCore.Mvc;

namespace SEDC.BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SEDC.BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SEDC.BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            var burgers = StaticDB.Burgers;
            return View(burgers);
        }
    }
}

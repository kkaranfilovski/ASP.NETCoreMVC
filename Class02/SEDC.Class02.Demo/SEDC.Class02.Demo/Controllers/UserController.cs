using Microsoft.AspNetCore.Mvc;

namespace SEDC.Class02.Demo.Controllers
{
    //[Route("UserApp")]
    public class UserController : Controller
    {
        [Route("All")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("CallMe")]
        public IActionResult Contact()
        {
            return new EmptyResult();
        }
    }
}

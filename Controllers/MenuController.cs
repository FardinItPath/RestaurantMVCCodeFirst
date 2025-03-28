using Microsoft.AspNetCore.Mvc;

namespace RestaurantMVCCodeFirst.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

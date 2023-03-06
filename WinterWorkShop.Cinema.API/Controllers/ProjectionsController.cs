using Microsoft.AspNetCore.Mvc;

namespace WinterWorkShop.Cinema.API.Controllers
{
    public class ProjectionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

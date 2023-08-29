using Microsoft.AspNetCore.Mvc;

namespace Mvc_project.Controllers
{
    public class HomePageController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}

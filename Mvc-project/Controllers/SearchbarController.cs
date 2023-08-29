using Microsoft.AspNetCore.Mvc;

namespace Mvc_project.Controllers
{
    public class SearchbarController : Controller
    {
        [HttpGet]
        public IActionResult SearchBar()
        {
            return View();
        }
        [HttpPost]
        [ActionName("SearchBar")]
        public IActionResult SubmitTag()
        {
            var SearchBar = Request.Form["searchbar"];
            return View("SearchBar");
        }
    }
}

using Bloggie.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_project.Controllers
{
    public class PeopleReviewsController : Controller
    {
        private BloggieDbContext bloggieDbContext;
        public PeopleReviewsController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }
        [HttpGet]
        public IActionResult Reviews()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitTag()
        {

            var Rating= Request.Form["rating"];
            var Review_Text = Request.Form["reviewtext"];
            var Review_Date = Request.Form["rating_date"];

            return View("Reviews");
        }

    }
}

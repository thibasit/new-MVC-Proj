using Bloggie.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Mvc_project.Models.Tables;

namespace Mvc_project.Controllers
{
    public class UserRefistrationController : Controller
    {
        private BloggieDbContext bloggieDbContext;
        public UserRefistrationController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext=bloggieDbContext;
        }


        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Registration")]
        public IActionResult SumbitTag ()
        {
            Users user =new Users();
            user.UserName = Request.Form["name"];
            user.UserEmail= Request.Form["email"];
            user.PasswordHash= Request.Form["password"];

            bloggieDbContext.Users.Add(user);
            bloggieDbContext.SaveChanges();


            return View("Registration");
        }
    }
}

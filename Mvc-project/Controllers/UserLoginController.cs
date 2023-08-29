using Bloggie.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Mvc_project.Models.Tables;

namespace Mvc_project.Controllers
{
    public class UserLoginController : Controller
    {
        private BloggieDbContext bloggieDbContext;
        public UserLoginController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public IActionResult Login(Users addTagRequest)
        {
            Users login = new Users()
            {
                UserEmail = addTagRequest.UserEmail,
                PasswordHash = addTagRequest.PasswordHash
            };


            var user = bloggieDbContext.Users.FirstOrDefault(u => u.UserEmail == login.UserEmail);
            if (user != null)
            {
                if (user.PasswordHash != login.PasswordHash)
                {
                    ViewBag.errormessage = "not a valid user";
                    return View();
                }
                else
                {
                    return View("index", "Home");
                }
            }
            else
            {
                ViewBag.errormessage = "not a valid user";
            }

            bloggieDbContext.Users.Add(login);
            bloggieDbContext.SaveChanges();

            return View("Login");
        }
    }
}

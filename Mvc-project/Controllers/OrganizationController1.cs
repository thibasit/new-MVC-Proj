using Bloggie.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Mvc_project.Models.Tables;

namespace Mvc_project.Controllers
{
    public class OrganizationController1 : Controller
    {
        private BloggieDbContext bloggieDbContext;
        public OrganizationController1 (BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        [HttpGet]
        public IActionResult Organization()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitTag()
        {
            Organization Org = new Organization();
            Org.Name = Request.Form["name"];
            Org.Address = Request.Form["adress"];
            Org.Phone = Request.Form["Phone"];
            Org.GoogleMapLocation = Request.Form["GoogleMapLocation"];

            bloggieDbContext.Organization.Add(Org);
            bloggieDbContext.SaveChanges();
            return View("Organization");
        }
    }
}

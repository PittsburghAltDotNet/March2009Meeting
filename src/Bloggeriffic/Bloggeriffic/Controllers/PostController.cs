using System.Collections.Generic;
using System.Web.Mvc;

namespace Bloggeriffic.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Index()
        {
            ViewData["posts"] = new[] { "My Post 1", "My Post 2", "My Post 3"};
            return View();
        }

        public ViewResult Post(int id)
        {
            ViewData["post"] = "first post";
            return View();
        }
    }
}
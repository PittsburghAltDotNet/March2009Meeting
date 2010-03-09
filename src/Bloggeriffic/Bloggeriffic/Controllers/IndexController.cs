using System.Collections.Generic;
using System.Web.Mvc;

namespace Bloggeriffic.Controllers
{
    public class IndexController : Controller
    {
        public IEnumerable<string> GetAllPosts()
        {
            return new[] { "My Post 1", "My Post 2", "My Post 3"};
        }
    }
}
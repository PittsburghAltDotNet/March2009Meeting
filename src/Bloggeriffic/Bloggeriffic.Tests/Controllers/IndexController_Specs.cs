using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bloggeriffic.Controllers;
using NUnit.Framework;

namespace Bloggeriffic.Tests.Controllers
{
    [TestFixture]
    public class IndexController_Specs
    {
        [Test]
        public void Should_display_First_post()
        {
            var controller = new PostController();
            var posts = (ViewResult)controller.Post(1);

            var titles = (string)posts.ViewData["post"];

            Assert.IsNotNull(titles);
        }

        
    }
}
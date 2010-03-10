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
        #region Setup/Teardown

        [SetUp]
        public void Before_each_spec()
        {
            controller = new PostController();
        }

        #endregion

        private PostController controller;

        [Test]
        public void Should_display_First_post()
        {
            ViewResult posts = controller.Post(1);

            var titles = (string)posts.ViewData["post"];

            Assert.IsNotNull(titles);
        }

        [Test]
        public void Should_return_all_available_posts()
        {
            var posts = (ViewResult)controller.Index();
            var titles = (IEnumerable<string>)posts.ViewData["posts"];
            Assert.That(titles.Count(), Is.EqualTo(3));
        }
    }
}
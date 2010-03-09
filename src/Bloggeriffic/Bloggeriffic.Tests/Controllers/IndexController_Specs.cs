using System.Linq;
using Bloggeriffic.Controllers;
using NUnit.Framework;

namespace Bloggeriffic.Tests.Controllers
{
    [TestFixture]
    public class IndexController_Specs
    {
        [Test]
        public void Should_display_all_available_posts()
        {
            var controller = new IndexController();
            var posts = controller.GetAllPosts();

            Assert.AreEqual(3, posts.Count());
        }

    }
}
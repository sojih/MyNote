using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNote;
using MyNote.Controllers;
using System.Web.Mvc;

namespace MyNote.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 정렬
            HomeController controller = new HomeController();

            // 작동
            ViewResult result = controller.Index() as ViewResult;

            // 어설션
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}

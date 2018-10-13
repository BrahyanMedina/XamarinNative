using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamarinNative.API;
using XamarinNative.API.Controllers;

namespace XamarinNative.API.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}

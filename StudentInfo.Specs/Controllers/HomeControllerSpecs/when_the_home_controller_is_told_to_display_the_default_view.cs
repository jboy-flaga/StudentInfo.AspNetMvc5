using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfo.Mvc5.Controllers;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Specs.Controllers.HomeControllerSpecs
{
    [TestClass]
    public class when_the_home_controller_is_told_to_display_the_default_view
    {
        [TestMethod]
        public void it_should_return_the_home_view()
        {
            // arrange
            HomeController controller = new HomeController();

            // act
            ViewResult result = controller.Index() as ViewResult;

            // assert
            Assert.IsTrue(string.IsNullOrEmpty(result.ViewName));
        }

        [TestMethod]
        public void it_should_display_the_welcome_message_in_the_view()
        {
            // arrange
            HomeController controller = new HomeController();

            // act
            controller.Index();

            // assert
            Assert.AreEqual("Welcome!", controller.ViewBag.Message);
        }
    }
}

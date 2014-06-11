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
        HomeController _controller;
        ViewResult _viewResult;

        [TestInitialize]
        public void Setup()
        {
            // given
            _controller = new HomeController();

            // when
            _viewResult = _controller.Index() as ViewResult;
        }

        [TestMethod]
        public void it_should_return_the_home_view()
        {
            // then
            Assert.IsTrue(string.IsNullOrEmpty(_viewResult.ViewName));
        }

        [TestMethod]
        public void it_should_display_the_welcome_message_in_the_view()
        {
            // then
            Assert.AreEqual("Welcome!", _controller.ViewBag.Message);
        }
    }
}

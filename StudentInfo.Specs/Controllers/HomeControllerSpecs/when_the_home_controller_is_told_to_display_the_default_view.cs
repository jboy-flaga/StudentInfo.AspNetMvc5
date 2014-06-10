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
        HomeController m_controller;
        ViewResult m_viewResult;

        [TestInitialize]
        public void Setup()
        {
            // arrange
            m_controller = new HomeController();

            // act
            m_viewResult = m_controller.Index() as ViewResult;
        }

        [TestMethod]
        public void it_should_return_the_home_view()
        {
            // assert
            Assert.IsTrue(string.IsNullOrEmpty(m_viewResult.ViewName));
        }

        [TestMethod]
        public void it_should_display_the_welcome_message_in_the_view()
        {
            // assert
            Assert.AreEqual("Welcome!", m_controller.ViewBag.Message);
        }
    }
}

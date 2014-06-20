using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentInfo.Web.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using StudentInfo.Web.Models;

namespace StudentInfo.Specs.Controllers.HomeControllerSpecs
{
   
    public partial class StudentControllerTest
    {
        static StudentController _studentController = new StudentController();

         [TestClass]
        public class When_the_index_view_is_loaded
        {
            ViewResult _viewResult;

            [TestInitialize]
            public void Setup()
            {
                // arrange
                //_studentController

                // act
                _viewResult = _studentController.Index() as ViewResult;
            }

            [TestMethod]
            public void it_displays_a_list_of_students()
            {
                Assert.IsInstanceOfType(_viewResult.Model, typeof(IEnumerable<Student>));
            }
        }
    }
}

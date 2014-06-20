using System;
using StudentInfo.Web.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using Xunit;
using Moq;
using StudentInfo.Infrastructure.Repository;
using StudentInfo.Domain.Model;

namespace StudentInfo.Specs.Controllers.HomeControllerSpecs
{
    public partial class StudentControllerTest
    {
        StudentController _studentController;
        Mock<StudentRepository> _fakeStudentRepository;

        public StudentControllerTest()
        {
            // arrange
            _fakeStudentRepository = new Mock<StudentRepository>();
            _studentController = new StudentController();
            //_studentController = new StudentController(_fakeStudentRepository.Object);
        }

        public class When_the_index_view_is_loaded : StudentControllerTest
        {
            ViewResult _viewResult;

            public When_the_index_view_is_loaded()
            {
                // act
                _viewResult = _studentController.Index() as ViewResult;
            }

            [Fact]
            public void it_displays_a_list_of_students()
            {
                // assert
                Assert.IsAssignableFrom<IEnumerable<Student>>(_viewResult.Model);
            }
        }

        public class When_adding_a_new_student : StudentControllerTest
        {
            [Fact]
            public void first_name_is_required()
            {
                // arrange
                var studentWithEmptyFirstName = new Student() { FirstName = "", LastName = "Lname" };

                // act
                var httpStatusCodeResult = _studentController.Add(studentWithEmptyFirstName) as HttpStatusCodeResult;

                // assert
                Assert.IsAssignableFrom<HttpStatusCodeResult>(httpStatusCodeResult);
                Assert.Equal((int)System.Net.HttpStatusCode.BadRequest, httpStatusCodeResult.StatusCode);
            }

            [Fact]
            public void last_name_is_required()
            {
                // arrange
                var studentWithEmptyLastName = new Student() { FirstName = "Fname", LastName = "" };

                // act
                var httpStatusCodeResult = _studentController.Add(studentWithEmptyLastName) as HttpStatusCodeResult;

                // assert
                Assert.IsAssignableFrom<HttpStatusCodeResult>(httpStatusCodeResult);
                Assert.Equal((int)System.Net.HttpStatusCode.BadRequest, httpStatusCodeResult.StatusCode);
            }

            [Fact]
            public void the_new_student_is_added_to_the_repository()
            {

                // arrange
                var student = new Student() { FirstName = "Fname", LastName = "Lname" };

                // act
                var viewResult = _studentController.Add(student) as ViewResult;

                // assert
                //_fakeStudentRepository.Verify(studRepo => studRepo.Add(It.IsAny<Student>()), Times.AtLeastOnce);
                throw new NotImplementedException("uncomment the code above after adding dependency injection");
            }

            [Fact]
            public void redirects_to_index_view()
            {
                // arrange
                var student = new Student() { FirstName = "Fname", LastName = "Lname" };

                // act
                var viewResult = _studentController.Add(student) as ViewResult;

                // assert
                Assert.Equal("Index", viewResult.ViewName);
            }
        }
    }
}

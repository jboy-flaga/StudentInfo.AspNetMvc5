using StudentInfo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInfo.Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var listOfStudents = new List<Student>();
            listOfStudents.Add(new Student { Id = 1, FirstName = "Jboy", LastName = "Flaga" });
            listOfStudents.Add(new Student { Id = 2, FirstName = "Camille", LastName = "Flaga" });

            return View(listOfStudents);
        }
    }
}
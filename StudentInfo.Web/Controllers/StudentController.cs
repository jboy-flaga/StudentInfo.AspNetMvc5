using StudentInfo.Domain.Model;
using StudentInfo.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInfo.Web.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository _studentRepository;

        public StudentController()
        {
            _studentRepository = new StudentRepository();

        }

        // GET: Student
        public ActionResult Index()
        {
            var students = _studentRepository.GetAll();

            return View(students);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName))
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            _studentRepository.Add(student);

            return View("Index", _studentRepository.GetAll());
        }
    }
}
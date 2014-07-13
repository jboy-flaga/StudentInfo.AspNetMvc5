using StudentInfo.Domain.Model;
using StudentInfo.Domain.Repository;
using StudentInfo.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInfo.Web.Controllers
{
    public class StudentController : Controller
    {
        private IRegistrationRepository _registrationRepository;

        public StudentController(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;

        }

        // GET: Student
        public ActionResult Index()
        {
            var students = _registrationRepository.GetAllStudents();

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

            _registrationRepository.Register(student);
            _registrationRepository.Save();

            return RedirectToAction("Index");
        }
    }
}
using StudentInfo.Domain.Model;
using StudentInfo.Domain.Repository;
using StudentInfo.Infrastructure.Data.BoundedContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Infrastructure.Data.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private RegistrationContext _registrationContext;

        public RegistrationRepository()
        {
            _registrationContext = new RegistrationContext();
        }

        public void Register(Student student)
        {
            _registrationContext.Students.Add(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _registrationContext.Students.ToList();
        }
        
        public void Save()
        {
            _registrationContext.SaveChanges();
        }

    }
}

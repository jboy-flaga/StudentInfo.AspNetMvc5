using StudentInfo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Domain.Repository
{
    public interface IRegistrationRepository
    {
        void Register(Student student);
        IEnumerable<Student> GetAllStudents();
        void Save();
    }
}

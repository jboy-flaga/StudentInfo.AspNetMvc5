using StudentInfo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Domain.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        void Add(Student newStudent);
    }
}

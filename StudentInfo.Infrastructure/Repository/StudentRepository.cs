using StudentInfo.Domain.Model;
using StudentInfo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Infrastructure.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private static ICollection<Student> _students = new List<Student>();

        public IEnumerable<Domain.Model.Student> GetAll()
        {
            return _students;
        }

        public virtual void Add(Student newStudent)
        {
            _students.Add(newStudent);
        }
    }
}

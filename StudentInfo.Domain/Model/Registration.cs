using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Domain.Model
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public int DegreeId { get; set; }
        public int SchoolYearFrom { get; set; }
        public int SchoolYearTo { get; set; }
        public int Semester { get; set; }

    }
}

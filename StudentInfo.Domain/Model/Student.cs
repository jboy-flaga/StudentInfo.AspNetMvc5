using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInfo.Domain.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Domain.Model
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string Name { get; set; }
        public int NumberOfUnits { get; set; }
    }
}

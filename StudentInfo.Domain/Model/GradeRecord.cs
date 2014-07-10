using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Domain.Model
{
    public class GradeRecord
    {
        public int SubjectId { get; set; }
        public decimal Grade { get; set; }
        public int? RegistrationId { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Subject Subject { get; set; }
    }
}

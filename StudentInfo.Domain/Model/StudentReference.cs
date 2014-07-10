using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Domain.Model
{
    /// <summary>
    /// Some contexts/domains might not need all information about a student. Use this class in that case.
    /// This will help reduce the use of resources.
    /// </summary>
    [Table("Students")]
    public class StudentReference
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}

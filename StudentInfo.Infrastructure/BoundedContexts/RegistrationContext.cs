using StudentInfo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Infrastructure.Data.BoundedContexts
{
    public class RegistrationContext : BaseContext<RegistrationContext>
    {
        public DbSet<Student> Students { get; set; }
    }
}

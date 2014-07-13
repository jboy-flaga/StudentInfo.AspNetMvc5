using System;
using StudentInfo.Domain.Model;
using System.Data.Entity;

namespace StudentInfo.Infrastructure.Data.BoundedContexts
{
    public class EnrollmentContext : BaseContext<EnrollmentContext>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<EnrollmentRecord> Registrations { get; set; }
    }
}

using StudentInfo.Domain.Model;
using StudentInfo.Infrastructure.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.DatabaseInitialization
{
    // JBOY: This is from Julie Lerman
    //      Because we use multiple contexts in our application (EnrollmentContext, BillingContext, 
    //      GradesContext, etc), we need to create a separate context that will be used only for 
    //      database initialization.
    //      This context will not be used in the application - only for database initialization.
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext()
            : base("name=StudentInfoDB")
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<GradeRecord> GradeRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GradeRecordDbMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

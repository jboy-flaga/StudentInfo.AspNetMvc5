using System;
using StudentInfo.Domain.Model;
using System.Data.Entity;
using StudentInfo.Infrastructure.Data.Mapping;

namespace StudentInfo.Infrastructure.Data.BoundedContexts
{
    public class GradesContext : BaseContext<GradesContext>
    {
        public DbSet<StudentReference> Students { get; set; }
        public DbSet<GradeRecord> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GradeRecordDbMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

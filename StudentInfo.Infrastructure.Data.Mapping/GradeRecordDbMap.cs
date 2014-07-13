using StudentInfo.Domain.Model;
using System;
using System.Data.Entity.ModelConfiguration;

namespace StudentInfo.Infrastructure.Data.Mapping
{
    public class GradeRecordDbMap : EntityTypeConfiguration<GradeRecord>
    {
        public GradeRecordDbMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EnrollmentRecordId, t.SubjectId });
        }
    }
}
